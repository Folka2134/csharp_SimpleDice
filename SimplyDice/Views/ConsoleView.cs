using SimplyDice.Services;

namespace SimplyDice.Views
{
    public class ConsoleView : IView
    {

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string UserInput()
        {
            return Console.ReadLine();
        }
    }
}