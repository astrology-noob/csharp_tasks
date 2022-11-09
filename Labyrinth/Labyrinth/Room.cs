namespace Labyrinth
{
    public class Room : MapSite
    {
        public int RoomNo { get; set; }
        private Dictionary<Direction, MapSite> Sides = new();

        public Room(int roomNo)
        {
            RoomNo = roomNo;
        }

        public MapSite GetSide(Direction direction)
        {
            return Sides[direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            Sides[direction] = mapSite;
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату номер {0}", RoomNo);
        }
    }
}
