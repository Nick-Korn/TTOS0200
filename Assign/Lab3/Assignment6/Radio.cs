using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Radio
    {
        public readonly int MaxVolume = 9;
        public readonly int MinVolume = 0;
        public readonly double MaxFrequency = 26000.0;
        public readonly double MinFrequency = 20000.0;
        private bool isValidInput;
        private bool powerState;
        private int volume = 0;
        private double channelFrequency = 0;

        public bool PowerState
        {
            get
            {
                return powerState;
            }
            set
            {
                powerState = value;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < MinVolume)
                {
                    isValidInput = false;
                }
                else if (value > MaxVolume)
                {
                    isValidInput = false;
                }
                else
                {
                    isValidInput = true;
                    volume = value;
                }
            }
        }
        public double ChannelFrequency
        {
            get
            {
                return channelFrequency;
            }
            set
            {
                if (value < MinFrequency)
                {
                    isValidInput = false;
                }
                else if (value > MaxFrequency)
                {
                    isValidInput = false;
                }
                else
                {
                    isValidInput = true;
                    channelFrequency = value;
                }
            }
        }
        public bool IsValidInput
        {
            get { return isValidInput; }
        }
        public bool PowerOn()
        {
            powerState = true;
            return powerState;
        }
        public bool PowerOff()
        {
            powerState = false;
            return powerState;
        }
        public string InputMessage()
        {
            if (isValidInput)
            {
                return string.Format("Current volume: {0}, Current channel frecuency {1} hz", Volume, ChannelFrequency);
            }
            else
            {
                return "Invalid input";
            }
        }
    }
}
