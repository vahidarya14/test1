using Infrastructure.Database;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1.Core.Application;

public class IOC
{
    static ServiceProvider ServiceProvider;
    public static void RegisterService()
    {
        ServiceProvider= new ServiceCollection()
                        .AddDbContext<AppDbContext>()
                        .AddScoped<FlightService>()
                        .AddScoped<DbHelper>()
                        .BuildServiceProvider();
    }

    public T Get<T>()=> ServiceProvider.GetRequiredService<T>();
}
