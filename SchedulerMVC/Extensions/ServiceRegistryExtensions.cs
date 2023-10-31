using Lamar;
using Microsoft.EntityFrameworkCore;
using SchedulerDB;

namespace SchedulerMVC.Extensions
{
    public static class ServiceRegistryExtensions
    {
        public static ServiceRegistry AddDatabase(this ServiceRegistry serviceRegistry)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            serviceRegistry.For<DbContext>().Use<SchedulerDbContext>()
                .Ctor<DbContextOptions<SchedulerDbContext>>()
                .Is(ctx =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<SchedulerDbContext>();
                    optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));
                    return optionsBuilder.Options;
                });

            return serviceRegistry;
        }
    }
}
