using Domain;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Database;
using System.ComponentModel.Design.Serialization;

namespace ConsoleApp1.Core.Application;

public class FlightService(AppDbContext db)
{
    public async Task<List<SearchResult>> Search(DateOnly startDate, DateOnly endDate, int agencyId)
    {

        var res = from route in db.routes
                  join flight in db.flights on route.route_id equals flight.route_id
                  join subscr in db.subscriptions on route.origin_city_id equals subscr.origin_city_id
                  where subscr.agency_id == agencyId && route.departure_date >= startDate && route.departure_date <= endDate
                  select new SearchResult
                  {
                      airline_id = flight.airline_id,
                      arrival_time = flight.arrival_time,
                      departure_time = flight.departure_time,
                      flight_id = flight.flight_id,
                      destination_city_id = subscr.destination_city_id,
                      origin_city_id = subscr.origin_city_id,
                      status = "",
                  };
        var lst = await res.OrderBy(x => x.departure_time).ToListAsync();

        await DetectState( lst);

        return lst;
    }

    private  async Task DetectState( List<SearchResult> lst)
    {
        var sevenDaysPlusMinuts = 10080 + 30;//7days + 30 minutes
        var sevenDaysMinMinuts = 10080 - 30; //7days - 30 minutes

        //load base date from database
        var allflights = await db.flights
            .Select(x => new
            {
                x.airline_id,
                discontinued_max = ((DateTimeOffset)x.departure_time.AddMinutes(sevenDaysPlusMinuts)).ToUnixTimeSeconds(),
                discontinued_min = ((DateTimeOffset)x.departure_time.AddMinutes(sevenDaysMinMinuts)).ToUnixTimeSeconds(),
                new_max = ((DateTimeOffset)x.departure_time.AddMinutes(-sevenDaysPlusMinuts)).ToUnixTimeSeconds(),
                new_min = ((DateTimeOffset)x.departure_time.AddMinutes(-sevenDaysMinMinuts)).ToUnixTimeSeconds()
            })
            .ToListAsync();


        for (var i = 0; i < lst.Count; i++)
        {
            //a new flight if no flight from same airline exists with departure time T’ = T - 7 days (+/- 30 minutes tolerance).
            var f = allflights.Any(x => lst[i].airline_id == x.airline_id &&
                                       lst[i].dt >= x.new_min &&
                                       lst[i].dt <= x.new_max);
            if (!f)
            {
                lst[i].status = "new";
            }

            //discontinued if no flight from same airline exists with departure time T’ = T + 7 days (+/- 30 minutes tolerance)
            f = allflights.Any(x => lst[i].airline_id == x.airline_id &&
                                    lst[i].dt >= x.discontinued_min &&
                                    lst[i].dt <= x.discontinued_max);
            if (!f)
            {
                lst[i].status = "discontinued";
            }
        }
    }
}


public class SearchResult
{
    public int flight_id { get; set; }
    public int origin_city_id { get; set; }
    public int destination_city_id { get; set; }
    public int airline_id { get; set; }
    public DateTime departure_time { get; set; }
    public DateTime arrival_time { get; set; }
    public string status { get; set; }// New / Discontinued

    public DateTime next_max_departure_time { get; set; }
    public DateTime next_min_departure_time { get; set; }

    public long dt => ((DateTimeOffset)departure_time).ToUnixTimeSeconds();
}