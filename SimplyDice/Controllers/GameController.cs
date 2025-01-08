using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using SimplyDice.Services;
using SimplyDice.Views;

namespace SimplyDice.Controllers
{
    public class GameController
    {
        private int userScore;
        private int aiScore;
        private int roundsCounter;
        private readonly ConsoleView _view;
        private readonly IDiceRoller _diceRoller;

        public GameController(IDiceRoller diceRoller)
        {
            _view = new ConsoleView();
            _diceRoller = diceRoller;
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

                Console.WriteLine();
                _view.DisplayMessage("Roll or Quit?");
                var input = _view.UserInput();

                if (input.ToLower() == "quit")
                {
                    _view.DisplayMessage("Exiting game...");
                    break;
                }


                var userRoll = _diceRoller.Roll();
                var aiRoll = _diceRoller.Roll();

                _view.DisplayMessage($"You rolled a {userRoll}");
                _view.DisplayMessage($"Ai rolled a {aiRoll}");

                if (userRoll > aiRoll)
                {
                    userScore++;
                    _view.DisplayMessage("You win this round!");
                }
                else if (aiRoll > userRoll)
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
        }

    }
}