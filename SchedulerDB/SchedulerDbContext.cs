using Microsoft.EntityFrameworkCore;
using SchedulerDB.Models;

namespace SchedulerDB;

// POC for if we want to use a database - but as it's an interview, I'm not going to bother wiring it up
public class SchedulerDbContext : DbContext
{
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Person> People { get; set; }

    public SchedulerDbContext() : base()
    {
    }

}
