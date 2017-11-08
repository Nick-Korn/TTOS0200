using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void ThrowDice()
        {
            try
            {
                // Assignment 1
                int rollAmounts;
                int roll;
                List<int> numberList = new List<int>();
                Dice test = new Dice();
                Console.WriteLine("How many dice throws?");
                rollAmounts = int.Parse(Console.ReadLine());
                for (int i = 0; i < rollAmounts; i++)
                {
                    roll = test.ThrowDice();
                    numberList.Add(roll);
                }
                double avg = numberList.Average();
                Console.WriteLine("The average of the throws is: {0}", avg);
                for (int i = 1; i < 7; i++)
                {
                    int x = 0;
                    foreach (int number in numberList)
                    {
                        if (i == number)
                        {
                            x++;
                        }
                    }
                    Console.WriteLine("The number {0} appears {1} times", i, x);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        static void CollectProducts()
        {
            try
            {
                List<Product> products = new List<Product>();
                products.Add(new Product("Juice", 1.4f));
                products.Add(new Product("Cookies", 2.1f));
                products.Add(new Product("Coffe", 4.2f));
                products.Add(new Product("Ham", 6.1f));
                Console.WriteLine("All the product in the collection:");
                foreach (Product product in products)
                {
                    Console.WriteLine(" - Product: {0} {1} e", product.ProductName, product.ProductPrize);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void AddFisher()
        {
            try
            {
                Fisherman kernel = new Fisherman("Kirsi Kernel", "020-12345678");
                Console.WriteLine("A new fisherman add to register: \n - Fisherman: {0} Phone {1} \n", kernel.Name, kernel.PhoneNumber);
                Fish pike = new Fish("pike", "The Lake of Jyväskylä", "Jyväskylä", 120, 4.5f);
                Console.WriteLine("Fisher: {0} caught a new fish: \n - species: {1} {2} cm {3} kg \n - place: {4} \n - location: {5} \n",
                    kernel.Name, pike.Species, pike.Lenght, pike.Weight, pike.Place, pike.Location);
                kernel.CatchList.Add(pike);
                Fish salmon = new Fish("salmon", "River Teno", "The northen edge of Finalad", 190, 13.2f);
                Console.WriteLine("Fisher: {0} caught a new fish: \n - species: {1} {2} cm {3} kg \n - place: {4} \n - location: {5} \n", 
                    kernel.Name, salmon.Species, salmon.Lenght, salmon.Weight, salmon.Place, salmon.Location);
                kernel.CatchList.Add(salmon);
                Fish bass = new Fish("Striped bass", "Chesapeake Bay", "Virginia", 74, 14.5f);
                kernel.CatchList.Add(bass);
                Console.WriteLine("Fisher: {0} caught a new fish: \n - species: {1} {2} cm {3} kg \n - place: {4} \n - location: {5} \n", 
                    kernel.Name, bass.Species, bass.Lenght, bass.Weight, bass.Place, bass.Location);
                Console.WriteLine(kernel.ToString());

                Console.WriteLine("Sorted register: \n");
                Console.WriteLine(kernel.ReversePrint());

            }
            catch (Exception)
            {

                throw;
            }

        }
        static void CalculateShapes()
        {
            try
            {
                Shapes shapeList = new Shapes();
                shapeList.ShapeList.Add(new Circle("Circle", 1));
                shapeList.ShapeList.Add(new Circle("Circle", 2));
                shapeList.ShapeList.Add(new Circle("Circle", 3));
                shapeList.ShapeList.Add(new Rectangle("Rectangle", 10, 20));
                shapeList.ShapeList.Add(new Rectangle("Rectangle", 20, 30));
                shapeList.ShapeList.Add(new Rectangle("Rectangle", 40, 50));
                Console.WriteLine(shapeList.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void CalculateArray()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine(ArrayCalcs.Sum(array));
                Console.WriteLine(ArrayCalcs.Avg(array));
                Console.WriteLine(ArrayCalcs.Max(array));
                Console.WriteLine(ArrayCalcs.Min(array));

            }
            catch (Exception)
            {

                throw;
            }
        }
        static void CreateInvoice()
        {
            try
            {
                Invoice kirsi = new Invoice("Kirsi Kernel");
                kirsi.Items.Add(new InvoiceItem("Milk", 1.75, 1));
                kirsi.Items.Add(new InvoiceItem("Beer", 5.25, 1));
                kirsi.Items.Add(new InvoiceItem("Milk", 2.50, 2));
                Console.WriteLine(kirsi.PrintInvoice());
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //ThrowDice();
                //CollectProducts();
                //AddFisher();
                //CalculateShapes();
                //CalculateArray();
                CreateInvoice();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}
