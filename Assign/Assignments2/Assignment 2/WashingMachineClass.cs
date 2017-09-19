using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class WashingMachine
    {

        private string washingMode = "Default.";
        private string[] washingProgram = new string[3] { "Sixty Degree Wash", "Forty Degree Wash", "Quick Wash" };
        public string WashingMode
        {
            get
            {
                return washingMode;

            }
            set
            {
                washingMode = value;
            }
        }

        public string[] WashingProgram
        {
            get
            {
                return washingProgram;
            }
            set
            {

            }
        }

        public bool PowerState { get; set; }
        public bool WashingPowder { get; set; }
        public bool Softener { get; set; }
        public bool WaterState { get; set; }

        public void TurnPowerOn()
        {
            Console.WriteLine("Power on!");
            PowerState = true;
        }
        public void TurnPowerOff()
        {
            Console.WriteLine("Power off!");
            PowerState = false;
        }
        public void TurnWaterOn()
        {
            Console.WriteLine("Water on!");
            WaterState = true;
        }
        public void TurnWaterOff()
        {
            Console.WriteLine("Water off!");
            WaterState = false;
        }
        public string SelectMode(int userInput)
        {
            WashingMode = WashingProgram[userInput];
            return WashingMode;
        }

        public void StartWash()
        {
            Console.WriteLine("Starting washing with {0} mode.", WashingMode);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("...");
                Console.ReadKey();
            }
            Console.WriteLine("\t *DING*");
            Console.WriteLine("Washing's done!");
        }
        public void AddSoftener()
        {
            Console.WriteLine("Softener added!");
            Softener = true;
        }
        public void AddWashingPowder()
        {
            Console.WriteLine("Washing powder added!");
            WashingPowder = true;
        }
    }
}
