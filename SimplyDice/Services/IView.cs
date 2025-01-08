namespace SimplyDice.Services
{
    public interface IView
    {
        void DisplayMessage(string message);
        string UserInput();
    }
}