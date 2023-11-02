using SchedulerDB.Models;

namespace SchedulerMVC.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly List<Person> people;
        public PersonRepository() { 
            people = new List<Person>();
        }

        public void AddPerson(Person newPerson)
        {
            people.Add(newPerson);
        }

        public void DeletePerson(Person newPerson)
        {
            people.Remove(newPerson);
        }

        public IEnumerable<Person> GetPeople()
        {
            return people;
        }

        public void UpdatePerson(Person updatePerson)
        {
            var person = people.FirstOrDefault(p => p.Id == updatePerson.Id);
            person = updatePerson;
        }
    }
}
