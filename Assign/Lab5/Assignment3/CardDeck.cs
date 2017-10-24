using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class CardDeck
    {
        public string Card { get; set; }
        static Random Random { get; set; }
        public List<string> Cards { get; set; }
        public CardDeck()
        {
            Cards = new List<string>();
        }
        static CardDeck()
        {
            Random = new Random();
        }

       public void AddCards()
        {
            for (int i = 0; i < 13; i++)
            {
                Cards.Add(string.Format("Heart#{0}", i+1));
            }
            for (int i = 0; i < 13; i++)
            {
                Cards.Add(string.Format("Spade#{0}", i+1));
            }
            for (int i = 0; i < 13; i++)
            {
                Cards.Add(string.Format("Diamond#{0}", i+1));
            }
            for (int i = 0; i < 13; i++)
            {
                Cards.Add(string.Format("Club#{0}", i+1));
            }
        }
        public void ShuffleDeck()
        {
            int n = Cards.Count();
            for (int i = 0; i < n; i++)
            {
                int r = i + Random.Next(n - i);
                string t = Cards[r];
                Cards[r] = Cards[i];
                Cards[i] = t;
            }
        }
        public override string ToString()
        {
            string retval = "";
            int i = 0;
            foreach (string card in Cards)
            {
                Console.WriteLine("{0}. card is {1}", i + 1, card);
                i++;
            }
            return retval;
        }
    }
}
