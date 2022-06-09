using SnakeandLadderSimulator;

namespace SnakeAndLadder
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator Program");
            SinglePlayerPosition position = new SinglePlayerPosition();
            position.StartPosition();
        }
    }
}