using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Dice
    {
        static Random DiceInt{ get; set; }
        public int DiceThrow { get; set; }

        static Dice()
        {
            DiceInt = new Random();
        }
        
        public int ThrowDice()
        {
            int DiceThrow = DiceInt.Next(1, 7);
            return DiceThrow;
        }
    }
}
