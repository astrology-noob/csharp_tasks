namespace Labyrinth
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Вы стукнулись о стену");
        }

    }
}
