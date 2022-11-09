namespace Labyrinth
{
    public enum Direction { North, South, East, West }

    public class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze maze = new();
            
            Room r1 = new(1);
            Room r2 = new(2);
            Door door = new(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, door);

            maze.start = 1;
            maze.finish = 2;

            return maze;
        }
    }
}
