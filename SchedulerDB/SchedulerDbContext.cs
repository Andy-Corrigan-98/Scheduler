using Microsoft.EntityFrameworkCore;
using SchedulerDB.Models;

namespace SchedulerDB;

public class SchedulerDbContext : DbContext
{
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Person> People { get; set; }

    public SchedulerDbContext() : base()
    {
    }

}
