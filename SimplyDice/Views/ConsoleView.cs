namespace SimplyDice.Views
{
    public class ConsoleView
    {

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public int UserInput()
        {
            Console.WriteLine();
            var input = Console.ReadLine();
            return int.Parse(input);
        }
    }
}