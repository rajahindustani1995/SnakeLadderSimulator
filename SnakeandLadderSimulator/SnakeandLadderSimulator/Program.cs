using SnakeandLadderSimulator;

namespace SnakeAndLadder
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator Program");
            DiceRolled num = new DiceRolled();
            num.Dice();
        }
    }
}