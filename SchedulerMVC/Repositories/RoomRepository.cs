using SchedulerDB.Models;

namespace SchedulerMVC.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly List<Room> rooms;
        public RoomRepository()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room newRoom)
        {
            rooms.Add(newRoom);
        }

        public void DeleteRoom(Room room)
        {
            rooms.Remove(room);
        }

        public IEnumerable<Room> GetRooms()
        {
            return rooms;
        }

        public void UpdateRoom(Room room)
        {
            var roomToUpdate = rooms.FirstOrDefault(r => r.Id == room.Id);
            roomToUpdate = room;
        }
    }
}
