using SimplyDice.Controllers;

namespace Simplydice
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameController();
            game.Run();
        }
    }
}