using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class AppDbContext : DbContext
{
    public DbSet<route> routes { get; set; }
    public DbSet<flight> flights { get; set; }
    public DbSet<subscription> subscriptions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;initial catalog=test;user id=sa;password=1234;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<route>().HasKey(x => x.route_id);
        modelBuilder.Entity<flight>().HasKey(x => x.flight_id);
        modelBuilder.Entity<subscription>().HasKey(x => x.Id);


        //using var reader = new StreamReader(@"bin\Debug\net8.0\backend-files\flights.csv");
        //List<flight> flights = [];
        var i = 0;
        //while (!reader.EndOfStream)
        //{
        //    var line = reader.ReadLine();
        //    if (i++ == 0) continue;
        //    var values = line.Split(',');

        //    flights.Add(new flight
        //    {
        //        flight_id = int.Parse(values[0]),
        //        route_id = int.Parse(values[1]),
        //        departure_time = DateTime.Parse(values[2]),
        //        arrival_time = DateTime.Parse(values[3]),
        //        airline_id = int.Parse(values[4]),
        //    });
        //}
        //modelBuilder.Entity<flight>().HasData(flights);


        //using var reader1 = new StreamReader(@"bin\Debug\net8.0\backend-files\routes.csv");
        //List<route> routes = [];
        //i = 0;
        //while (!reader1.EndOfStream)
        //{
        //    var line = reader1.ReadLine();
        //    if (i++ == 0) continue;
        //    var values = line.Split(',');

        //    routes.Add(new route
        //    {
        //        route_id = int.Parse(values[0]),
        //        origin_city_id = int.Parse(values[1]),
        //        destination_city_id = int.Parse(values[2]),
        //        departure_date = DateOnly.FromDateTime(DateTime.Parse(values[3])),
        //    });
        //}
        //modelBuilder.Entity<route>().HasData(routes);




        //using var reader2 = new StreamReader(@"bin\Debug\net8.0\backend-files\subscriptions.csv");
        //List<subscription> subscriptions = [];
        //i = 0;
        //while (!reader2.EndOfStream)
        //{
        //    var line = reader2.ReadLine();
        //    if (i++ == 0) continue;
        //    var values = line.Split(',');

        //    subscriptions.Add(new subscription
        //    {
        //        Id = i,
        //        agency_id = int.Parse(values[0]),
        //        origin_city_id = int.Parse(values[1]),
        //        destination_city_id = int.Parse(values[2])
        //    });
        //}
        //modelBuilder.Entity<subscription>().HasData(subscriptions);



        base.OnModelCreating(modelBuilder);
    }
}
