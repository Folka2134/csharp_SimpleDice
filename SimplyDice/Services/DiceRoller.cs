namespace SimplyDice.Services
{
    public class DiceRoller : IDiceRoller
    {
        private readonly Random _random = new();

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}