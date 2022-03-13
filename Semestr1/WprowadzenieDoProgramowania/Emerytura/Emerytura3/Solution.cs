using System;

internal class Solution
{
    private static void Main()
    {
        string[] consoleLine = Console.ReadLine().Split(" ");

        string lastName = consoleLine[0];
        int currentAge = int.Parse(consoleLine[1]);
        int retirementAge = int.Parse(consoleLine[2]);
        int ageChecker = retirementAge - currentAge;

        

        if (currentAge < 0 || retirementAge < 0)
            Console.WriteLine("Wiek nie może być ujemny!");
        else if (ageChecker == 1)
            Console.WriteLine($"Witaj {lastName}! Do emerytury brakuje Ci 1 rok!");
        else if (currentAge < retirementAge)
        {
            while (ageChecker > 10 && retirementAge - currentAge != 12 && retirementAge - currentAge != 13 && retirementAge - currentAge != 14)
                ageChecker -= 10;
            Console.Write($"Witaj {lastName}! ");
            switch (ageChecker)
            {
                case 2:
                case 3:
                case 4:
                    Console.Write($"Do emerytury brakuje Ci {retirementAge - currentAge} lata!");
                    break;

                default:
                    Console.Write($"Do emerytury brakuje Ci {retirementAge - currentAge} lat!");
                    break;
            }
        }
        else
            Console.WriteLine($"Witaj emerycie {lastName}!");

        return;
    }
}