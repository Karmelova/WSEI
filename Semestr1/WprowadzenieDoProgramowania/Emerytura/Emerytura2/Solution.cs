using System;

internal class Program
{
    private static void Main()
    {
        string lastName = Console.ReadLine();
        int currentAge = int.Parse(Console.ReadLine());
        int retirementAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Witaj, {lastName}!");

        if (currentAge < 0 || retirementAge < 0)
            Console.WriteLine("Wiek nie może być ujemny!");
        else if (currentAge < retirementAge)
        {
            int ageChecker = retirementAge - currentAge;
            while (ageChecker > 10)
                ageChecker -= 10;
            switch (ageChecker)
            {
                case 1:
                    Console.WriteLine($"Do emerytury brakuje Ci 1 rok!");
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"Do emerytury brakuje Ci {retirementAge - currentAge} lata!");
                    break;

                default:
                    Console.WriteLine($"Do emerytury brakuje Ci {retirementAge - currentAge} lat!");
                    break;
            }
        }
        else
            Console.WriteLine("Jesteś emerytem!");

        return;
    }
}