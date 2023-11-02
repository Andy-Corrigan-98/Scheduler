using SchedulerDB.Models;

namespace SchedulerMVC.Repositories
{
    public interface IRoomRepository
    {
        void AddRoom(Room newRoom);
        void DeleteRoom(Room room);
        IEnumerable<Room> GetRooms();
        void UpdateRoom(Room room);
    }
}
