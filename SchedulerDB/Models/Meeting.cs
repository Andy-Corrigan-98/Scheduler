using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerDB.Models
{
    public class Meeting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public Person Organizer { get; set; }
        public Room Room { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Meeting(string title, Person organizer, Room room, DateTime start, DateTime end)
        {
            Title = title;
            Organizer = organizer;
            Room = room;
            Start = start;
            End = end;
        }
    }
}
