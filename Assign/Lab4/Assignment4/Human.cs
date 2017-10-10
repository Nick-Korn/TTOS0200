using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Human : Mammal
    {
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }
        
        public Human (int age, float weight, float height, string name) :
            base(age)
        {
            Age = age;
            Weight = weight;
            Height = height;
            Name = name;
        }
        public override void Move()
        {
            Console.WriteLine("Moving");
        }
        public int DoAge()
        {
            Age += 1;
            return Age; 
        }
        public override string ToString()
        {
            return string.Format("Age: {0}, Weight: {1}, Height: {2}, Name: {3}", Age, Weight, Height, Name);
        }
    }
}
