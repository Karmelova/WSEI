﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string ToString()
        {
            return $"Treacher: {name} ({age} y.o.) \n\n";
        }
    }
}