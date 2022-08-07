using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Classroom
    {
        private string name;
        private Person[] persons;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string s = $"Classroom: {name}\n\n";
            foreach (Person p in persons)
            {
                s += $"{p}";
            }
            return s;
        }
    }
}