namespace SimplyDice.Views
{
    public class ConsoleView
    {

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string UserInput()
        {
            Console.WriteLine();
            return Console.ReadLine();
        }
    }
}