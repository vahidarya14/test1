
using Domain;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Core.Application;

public class DbHelper(AppDbContext db)
{
    public async Task Seed()
    {

        if (await db.routes.CountAsync() == 0)
        {
            using var reader = new StreamReader(@"backend-files\routes.csv");
            List<route> listA = [];
            var i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (i++ == 0) continue;
                var values = line.Split(',');

                listA.Add(new route
                {
                    route_id = int.Parse(values[0]),
                    origin_city_id = int.Parse(values[1]),
                    destination_city_id = int.Parse(values[2]),
                    departure_date = DateOnly.FromDateTime(DateTime.Parse(values[3])),
                });
            }
            await db.routes.AddRangeAsync(listA);
            await db.SaveChangesAsync();
        }


        if (await db.flights.CountAsync() == 0)
        {
            using var reader = new StreamReader(@"backend-files\flights.csv");
            List<flight> listA = [];
            var i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (i++ == 0) continue;
                var values = line.Split(',');

                listA.Add(new flight
                {
                    flight_id = int.Parse(values[0]),
                    route_id = int.Parse(values[1]),
                    departure_time = DateTime.Parse(values[2]),
                    arrival_time = DateTime.Parse(values[3]),
                    airline_id = int.Parse(values[4]),
                });
            }
            await db.flights.AddRangeAsync(listA);
            await db.SaveChangesAsync();
        }


        if (await db.subscriptions.CountAsync() == 0)
        {
            using var reader = new StreamReader(@"backend-files\subscriptions.csv");
            List<subscription> listA = [];
            var i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (i++ == 0) continue;
                var values = line.Split(',');

                listA.Add(new subscription
                {
                    agency_id = int.Parse(values[0]),
                    origin_city_id = int.Parse(values[1]),
                    destination_city_id = int.Parse(values[2])
                });
            }
            await db.subscriptions.AddRangeAsync(listA);
            await db.SaveChangesAsync();
        }
    }
}
