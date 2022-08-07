using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }

        public override void Print(string prefix)
        {
            Console.Write($"{prefix} Buyer: ");
            base.Print();

            if (tasks.Count > 0)
            {
                Console.WriteLine("\t\t-- Products: --");
                foreach (Product p in tasks)
                {
                    Console.Write("\t");
                    p.Print();
                }
            }
        }
    }
}