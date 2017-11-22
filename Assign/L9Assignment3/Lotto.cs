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
        public List<int> LottoLine { get; set; }

        public Lotto(int amountOfNumbers, int numberScale, bool starNumbers)
        {
            AmountOfNumbers = amountOfNumbers;
            NumberScale = numberScale;
            StarNumbers = starNumbers;
            LottoLine = new List<int>();
        }

        static Lotto()
        {
            // Static constructor for better randomazition
            SingleNumber = new Random();
        }

        public List<int> DrawLottoLine()
        {
            try
            {
                int temp;
                for (int i = 0; i < AmountOfNumbers; i++)
                {
                    temp = SingleNumber.Next(1, NumberScale);
                    LottoLine.Add(temp);
                }
                LottoLine.Sort();
                if (StarNumbers)
                {
                    LottoLine.Add(SingleNumber.Next(1, 10));
                    LottoLine.Add(SingleNumber.Next(1, 10));
                }
                return LottoLine;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
