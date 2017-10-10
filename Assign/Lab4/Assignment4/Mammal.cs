﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Mammal
    {
        public int Age { get; set; }
        public Mammal(int age)
        {
            Age = age;
        }
        public abstract void Move();
    }
}
