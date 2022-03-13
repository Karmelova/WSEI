using System;

namespace Solution
{
    internal class Solution
    {
        private static void Main()
        {
            var TriangleSides = Console.ReadLine().Split("; ");
            double Side1 = double.Parse(TriangleSides[0]);
            double Side2 = double.Parse(TriangleSides[1]);
            double Side3 = double.Parse(TriangleSides[2]);

            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
            {
                Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
                return;
            }
            else if ((Side1 + Side2) < Side3 || (Side2 + Side3) < Side1 || (Side1 + Side3) < Side2)
            {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                return;
            }

            //obwód
            double circuit = Math.Round(Side1 + Side2 + Side3, 2);
            double checkC = circuit;
            while (checkC > 0)
                checkC--;
            if (checkC == 0)
                Console.WriteLine($"obwód = {circuit}.00");
            else
                Console.WriteLine($"obwód = {circuit}");

            //Pitagoras
            double a = Math.Pow(Side1, 2);
            double b = Math.Pow(Side2, 2);
            double c = Math.Pow(Side3, 2);

            //pole
            double area = Math.Sqrt(circuit / 2 * (circuit / 2 - Side1) * (circuit / 2 - Side2) * (circuit / 2 - Side3));

            double checkA = area;
            while (checkA > 0)
                checkA--;
            if (checkA == 0)
                Console.WriteLine($"pole = {area}.00");
            else
                Console.WriteLine($"pole = {Math.Round(area, 2)}");

            //rodzaj

            if (Side1 == Side2 && Side3 == Side2)
            {
                Console.WriteLine("trójkąt jest ostrokątny");
                Console.WriteLine("trójkąt równoboczny");
                return;
            }
            else if (a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("trójkąt jest prostokątny");
                return;
            }
            else if (a + b < c || a + c < b || b + c < a)
                Console.WriteLine("trójkąt jest rozwartokątny");
            else
                Console.WriteLine("trójkąt jest ostrokątny");
            if (Side1 == Side2 || Side2 == Side3 || Side3 == Side1)
                Console.WriteLine("trójkąt równoramienny");
        }
    }
}