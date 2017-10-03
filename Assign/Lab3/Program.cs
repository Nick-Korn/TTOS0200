/*
 * lab3
 * 
 * Created by: Niko Liimatainen 25/09/2017
 * Modifeid by: Niko Liimatainen 26/09/2017
 *              -||- 2/10/2017
 *              -||- 3/10/2017
 * 
 * OOP TTOS0200 Assignments of lab #3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    class TestBed
    {
        static void Main(string[] args)
        {
            //UseInputTester();
            //UseElevator();
            //UseAmplifier();
            //UseEmployeeBase();
            //CreateVehicle();
            //UseRadio();
            CreateBookcaseItems();
        }

        static void UseInputTester ()
        {
            //Assginment 1
            string userInput;
            Lab3.InputTester test = new InputTester();
            while (true)
            {
                Console.WriteLine("Pleas input");
                userInput = Console.ReadLine();
                bool numberResult = test.IsItAInteger(userInput);
                Console.WriteLine("Your input {0} is a number: {1}\n", userInput, numberResult);
                bool dateResult = test.IsItADate(userInput);
                Console.WriteLine("Your input {0} is a date: {1}\n", userInput, dateResult);
            }

        }
        static void UseElevator ()
        {
            //Assginment 2
            Lab3.DynamoElevator leftElevator = new DynamoElevator();
            while (true)
            {
                Console.WriteLine("You are on floor {0}", leftElevator.Floor);
                Console.WriteLine("Please Input the floor you'd like to go: ");
                leftElevator.Floor = int.Parse(Console.ReadLine());
            }
        }
        static void UseAmplifier()
        {
            //Assginment 3
            Lab3.Amplifier ahuja = new Amplifier();
            while (true)
            {
                Console.WriteLine("Amplifier volume is: {0}", ahuja.Volume);
                Console.Write("Set amplifier volume to: ");
                ahuja.Volume = int.Parse(Console.ReadLine());
            }
        }
        static void UseEmployeeBase()
        {
            //Assginment 4
            Lab3.Employee Kirsi = new Employee("Kirsi Kernel", "Teacher", 1200);
            string dataPrint1 = Kirsi.PrintDataBase();
            Console.WriteLine(dataPrint1);
            Lab3.Employee Jussi = new Boss("Jussi Jurkka", "Head of Institute", 9000, "Audi", 5000);
            string dataPrint2 = Jussi.PrintDataBase();
            Console.WriteLine(dataPrint2);
            Kirsi.Profession = "Principal Teacher";
            Kirsi.Salary = 2200;
            string dataPrint3 = Kirsi.PrintDataBase();
            Console.WriteLine(dataPrint3);
        }
        static void CreateVehicle()
        {
            //Assginment 5
            Lab3.Vehicle Jopo = new Bike("Jopo", "Street", "Blue", 2016, false, " ");
            string dataPrint1 = Jopo.PrintVehicleData();
            Console.WriteLine(dataPrint1);
            Lab3.Vehicle Tunturi = new Bike("Tunturi", "StreetPower", "Black", 2010, true, "Shimano");
            string dataPrint2 = Tunturi.PrintVehicleData();
            Console.WriteLine(dataPrint2);
            Lab3.Vehicle Suvi = new Boat("Suvi", "S900", "White", 1990, 3, "Rowboat");
            string dataPrint3 = Suvi.PrintVehicleData();
            Console.WriteLine(dataPrint3);
            Lab3.Vehicle Yamaha = new Boat("Jopo", "Model 1000", "Yellow", 2010, 5, "Motorboat");
            string dataPrint4 = Yamaha.PrintVehicleData();
            Console.WriteLine(dataPrint4);
        }
        static void UseRadio()
        {
            //Assginment 6
            Lab3.Radio Philips = new Radio();
            bool userSelect;
            Philips.PowerOn();
            Console.WriteLine("Power on!");
            while (Philips.PowerState)
            {
                Console.WriteLine("Please select your action. \n\nPress any number key to set parameters. Press anything else to power off.");
                userSelect = int.TryParse(Console.ReadLine(), out int number);
                if (userSelect)
                {
                    Console.Clear();
                    Console.WriteLine("Please set the volume ({0}-{1})", Philips.MinVolume, Philips.MaxVolume);
                    int userInput = int.Parse(Console.ReadLine());
                    Philips.Volume = userInput;
                    Console.WriteLine(Philips.InputMessage());
                    Console.WriteLine("Please select the channel ({0}-{1})", Philips.MinFrequency, Philips.MaxFrequency);
                    int userInput2 = int.Parse(Console.ReadLine());
                    Philips.ChannelFrequency = userInput2;
                    Console.WriteLine(Philips.InputMessage() + '\n');
                }
                else
                {
                    Philips.PowerOff();
                }
            }
            Console.WriteLine("Power off!");
        }
        static void CreateBookcaseItems ()
        {
            //Assignmnet 7
            Lab3.Disc titanic = new Disc("Titanic", "Dvd", "Movie", "UDF bridge", "epic romance-disaster film", 194);
            Console.WriteLine(titanic.PrintData());
            Lab3.Disc reise = new Disc("Rammstein - 'Reise, Reise'", "Audio CD", "Studio Album", "MP3", "industrial metal", 2004);
            Console.WriteLine(reise.PrintData());
            Lab3.Technology gpu = new Technology("Graphics card", "MSI GamingX Geforce GTX 1080", 2016, true, true);
            Console.WriteLine(gpu.PrintData());
            Lab3.Technology smartPhone = new Technology("Smart Phone", "Honor 7", 2014, false, false);
            Console.WriteLine(smartPhone.PrintData());
            Lab3.Readable magazine = new Readable("Emp product magazine", "Magazine", "Magazine", "Emp FI", 332, 2017);
            Console.WriteLine(magazine.PrintData());
            Lab3.Readable novel = new Novel("A game of thrones", "Novel", "Paperback", "Harper Voyager", 694, 1996, "George R. R. Martin", true);
            Console.WriteLine(novel.PrintData());
            Lab3.Readable manga = new Comic("Yotsuba&! Volume #1", "Comic", "Paperback", "ADV MANGA", 231, 2005, "Kiyohiko Azuma", "Kiyohiko Azuma", true);
            Console.WriteLine(manga.PrintData());
        }
    }
}
