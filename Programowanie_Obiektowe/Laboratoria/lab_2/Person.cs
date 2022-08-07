using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Person : IEquatable<Person>
    {
        protected string name;
        protected int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{name} {age}";
        }
    }
}