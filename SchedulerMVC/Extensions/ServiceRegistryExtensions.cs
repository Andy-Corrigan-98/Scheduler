using Lamar;
using Microsoft.EntityFrameworkCore;
using SchedulerDB;

namespace SchedulerMVC.Extensions
{
    public static class ServiceRegistryExtensions
    {
        // POC for if we want to use a database - but as it's an interview, I'm not going to bother wiring it up
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

        public static ServiceRegistry AddRepositories(this ServiceRegistry serviceRegistry)
        {
            serviceRegistry.Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });

            return serviceRegistry;
        }
    }
}
