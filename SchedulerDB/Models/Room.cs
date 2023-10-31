using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerDB.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public Room(string name)
        {
            Name = name;
        }
    }
}
