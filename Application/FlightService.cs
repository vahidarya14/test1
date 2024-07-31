using Domain;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Database;

namespace ConsoleApp1.Core.Application;

public class FlightService(AppDbContext db)
{
    public async Task<List<SearchResult>> Search(DateOnly startDate, DateOnly endDate, int agencyId)
    {
        var res = from route in db.routes
                  join flight in db.flights on route.route_id equals flight.route_id
                  join s in db.subscriptions on route.origin_city_id equals s.origin_city_id
                  where s.agency_id == agencyId && route.departure_date >= startDate && route.departure_date <= endDate
                  select new SearchResult
                  {
                      airline_id = flight.airline_id,
                      arrival_time=flight.arrival_time,    
                      departure_time=flight.departure_time,
                      flight_id=flight.flight_id,
                      destination_city_id=s.destination_city_id,
                      origin_city_id=s.origin_city_id,
                      status="New"
                  };
        return await res.ToListAsync();
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
}