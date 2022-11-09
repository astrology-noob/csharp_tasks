namespace Labyrinth
{
    public class Door : MapSite
    {
        public Room Room1;
        public Room Room2;
        public bool IsOpen = false;

        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
        }

        public override void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Дверь открыта, вы входите");
                Room2.Enter();
            }
            else Console.WriteLine("Дверь закрыта");
        }
    }
}
