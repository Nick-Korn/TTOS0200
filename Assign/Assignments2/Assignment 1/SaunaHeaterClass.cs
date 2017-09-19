using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SaunaHeater
    {
        private int heat = 0;
        private int humidity = 0;

        public int Heat
        {
            get
            {
                return heat;
            }
            set
            {
                heat = value;
            }
        }

        public int Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                humidity = value;
            }
        }

        public bool powerState { get; set; }

        public void HeaterState()
        {
            Console.WriteLine("The state of the Sauna heater.");
            if (powerState == false)
            {
                Console.WriteLine("Sauna is off!");
            }
            else if (powerState == true)
            {
                Console.WriteLine("Sauna is on!");
                Console.WriteLine("Current temperature is {0} degreese celsius.", heat);
                Console.WriteLine("Current humidity is {0}%", humidity);
            }
        }
        
        public void TurnOn()
        {
            powerState = true;
        }

        public void TurnOff()
        {
            powerState = false;
        }

        public void IncreaseHeat()
        {
            Heat += 5;
        }
        public void DecreaseHeat()
        {
            Heat -= 5;
        }

        public void IncreaseHumidity()
        {
            Humidity += 5;
        }
        public void DecreaseHumidity()
        {
            Humidity += 5;
        }

    }
}
