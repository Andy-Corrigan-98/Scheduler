using SchedulerDB.Models;

namespace SchedulerMVC.Repositories
{
    public interface IEventRepository
    {
        void AddEvent(Meeting newEvent);
        void DeleteEvent(Meeting deleteEvent);
        IEnumerable<Meeting> GetEvents();
        void UpdateEvent(Meeting updateEvent);
    }
}
