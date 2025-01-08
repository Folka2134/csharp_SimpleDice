using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using SimplyDice.Views;

namespace SimplyDice.Controllers
{
    public class GameController
    {
        private int userScore;
        private int aiScore;
        private int roundsCounter;
        private readonly ConsoleView _view;

        public GameController()
        {
            _view = new ConsoleView();
            userScore = 0;
            aiScore = 0;
            roundsCounter = 1;
        }

        public void Run()
        {
            _view.DisplayMessage("Welcome to Simply Dice!");

            while (true)
            {
                if (roundsCounter >= 10)
                {
                    if (userScore > aiScore)
                    {
                        _view.DisplayMessage("You win!");
                        _view.DisplayMessage("Score: You: " + userScore + " Ai: " + aiScore);
                    }
                    else
                    {
                        _view.DisplayMessage("Ai wins!");
                        _view.DisplayMessage("Score: You: " + userScore + " Ai: " + aiScore);
                    }
                    break;
                }
                _view.DisplayMessage("Roll or Quit?");
                var input = _view.UserInput();

                if (input.ToLower() == "quit")
                {
                    _view.DisplayMessage("Exiting game...");
                    // stop program completely
                    break;
                }

                try
                {
                    var userRandomdiceRoll = new Random().Next(1, 7);
                    var aiRandomdiceRoll = new Random().Next(1, 7);

                    _view.DisplayMessage($"You rolled a {userRandomdiceRoll}");
                    _view.DisplayMessage($"Ai rolled a {aiRandomdiceRoll}");

                    if (userRandomdiceRoll > aiRandomdiceRoll)
                    {
                        userScore++;
                        _view.DisplayMessage("You win this round!");
                    }
                    else if (aiRandomdiceRoll > userRandomdiceRoll)
                    {
                        aiScore++;
                        _view.DisplayMessage("Ai wins this round!");
                    }
                    else
                    {
                        _view.DisplayMessage("It's a tie!");
                        roundsCounter--;
                    }
                    roundsCounter++;
                }
                catch (Exception ex)
                {
                    _view.DisplayMessage($"An error occurred: {ex.Message}");
                    throw;
                }
            }


        }

    }
}