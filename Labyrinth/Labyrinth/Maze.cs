namespace Labyrinth
{
    public class Maze
    {
        public Dictionary<int, Room> Rooms;
        public int start { get; set; }
        public int finish { get; set; }
        public Room curRoom { get; set; }

        public void AddRoom(Room room)
        {
            Rooms.Add(room.RoomNo, room);
        }

        public Room GetRoomByNo(int RoomNo)
        {
            return Rooms[RoomNo];
        }

    }
}
