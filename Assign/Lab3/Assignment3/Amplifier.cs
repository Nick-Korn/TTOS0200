using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Amplifier
    {
        private readonly int MaximiumVolume = 100;
        private readonly int MinimumVolume = 0;
        private int volume = 0;


        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < MinimumVolume)
                {
                    Console.WriteLine("Too low volume! Amplifier volume is set to minimum: {0}", MinimumVolume);
                    volume = MinimumVolume;
                }
                else if (value > MaximiumVolume)
                {
                    Console.WriteLine("Too nuch volume! Amplifier volume is set to maximum: {0}", MaximiumVolume);
                    volume = MaximiumVolume;
                }
                else
                {
                    volume = value;
                }
            }
        }
    }
}