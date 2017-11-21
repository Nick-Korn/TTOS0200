using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9Assignment3
{
    class Lotto
    {
        public int AmountOfNumbers { get; set; }
        public int NumberScale { get; set; }
        public bool StarNumbers { get; set; }
        static Random SingleNumber { get; set; }

        public Lotto(int amountOfNumbers, int numberScale, bool starNumbers)
        {
            AmountOfNumbers = amountOfNumbers;
            NumberScale = numberScale;
            StarNumbers = starNumbers;

        }

        static Lotto()
        {
            // Static constructor for better randomazition
            SingleNumber = new Random();
        }

        public string DrawLottoLine()
        {
            try
            {
                string line = "";
                for (int i = 0; i < AmountOfNumbers; i++)
                {
                    int temp = SingleNumber.Next(1, NumberScale);
                    line += temp + " ";
                }
                if (StarNumbers)
                {
                    line += SingleNumber.Next(1, 10) + " " + SingleNumber.Next(1, 10);
                }
                return line;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
