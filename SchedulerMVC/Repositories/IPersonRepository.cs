using SchedulerDB.Models;

namespace SchedulerMVC.Repositories
{
    public interface IPersonRepository
    {
        void AddPerson(Person newPerson);
        void DeletePerson(Person newPerson);
        IEnumerable<Person> GetPeople();
        void UpdatePerson(Person updatePerson);
    }
}
