using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerDB.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
