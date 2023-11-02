using SchedulerDB.Models;

namespace SchedulerMVC.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly List<Meeting> events;

        public EventRepository()
        {
            events = new List<Meeting>();
        }

        public IEnumerable<Meeting> GetEvents()
        {
            return events;
        }

        public void AddEvent(Meeting newEvent)
        {
            if (!events.Any() || !(RoomIsOverlapping(newEvent) || AttendeeIsOverlapping(newEvent)))
            {
                events.Add(newEvent);
            }
            else
            {
                throw new Exception("Event overlaps with existing event");
            }
        }

        private bool AttendeeIsOverlapping(Meeting newEvent)
            => events.Any(e => e.Attendees.Any(a => newEvent.Attendees.Contains(a)) && e.Start < newEvent.End && e.End > newEvent.Start);

        private bool RoomIsOverlapping(Meeting newEvent)
            => events.Any(e => e.Room == newEvent.Room && e.Start < newEvent.End && e.End > newEvent.Start);

        public void DeleteEvent(Meeting deleteEvent)
        {
            events.Remove(deleteEvent);
        }

        public void UpdateEvent(Meeting updatedEvent)
        {
            //ToDO: extend to check for attendee and room overlaps similar to AddEvent
            var index = events.FindIndex(e => e.Id == updatedEvent.Id);
            events[index] = updatedEvent;
        }

        public Meeting? GetEventById(int id)
        {
            return events.Find(e => e.Id == id);
        }
    }
}
