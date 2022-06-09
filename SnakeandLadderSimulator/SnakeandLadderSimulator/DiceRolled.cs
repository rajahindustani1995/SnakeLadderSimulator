using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderSimulator
{
    internal class DiceRolled
    {
        public void Dice()
        {
            int playerPosition = 0, diceRoll;
            Random rand = new Random();
            diceRoll = rand.Next(1, 7);
            Console.WriteLine("Number appeared on dice is : " + diceRoll);
        }
    }
}
