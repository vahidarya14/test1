using ConsoleApp1.Core.Application;
using Infrastructure.Database;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1;

internal class Program()
{
    static void Main(string[] args)
    {
       var res= Excute(args).Result;

        Console.WriteLine("Done. results.csv");
        Console.ReadKey();
    }

    static async Task<bool> Excute(string[] args)
    {
        var services = CreateServices();
        var flightService = services.GetRequiredService<FlightService>();
        var csvHelper = services.GetRequiredService<CsvHelper>();
        var dbHelper = services.GetRequiredService<DbHelper>();

        //await dbHelper.Seed();

        Console.WriteLine("loading...");

        if (args.Length > 2)
        {
            var startDate = DateTime.Parse(args[0]);
            var endDate = DateTime.Parse(args[1]);
            var agencyId = int.Parse(args[2]);
            var data = await flightService.Search(DateOnly.FromDateTime(startDate), DateOnly.FromDateTime(endDate), agencyId);
            csvHelper.MakeCsv(data);
        }
        else
        {
            var data = await flightService.Search(new DateOnly(2018, 01, 01), new DateOnly(2018, 01, 15), 1);
            csvHelper.MakeCsv(data);
            Console.WriteLine("usage:=>  ConsoleApp1.exe 2018-01-01 2018-01-15 1");
        }

        return true;
    }


    private static ServiceProvider CreateServices()
    {
        return new ServiceCollection()
                    .AddDbContext<AppDbContext>()
                    .AddScoped<FlightService>()
                    .AddScoped<DbHelper>()
                    .AddScoped<CsvHelper>()
                    .BuildServiceProvider();
    }
}
