using System;

class Solution
{
    static void Main()
    {
        string lastName = Console.ReadLine();
        int currentAge = int.Parse(Console.ReadLine());
        int retirementAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Witaj, {lastName}!");

        if (currentAge < 0 || retirementAge < 0)
            Console.WriteLine("Wiek nie może być ujemny!");
        else if (currentAge < retirementAge)
            Console.WriteLine($"Do emerytury brakuje Ci {retirementAge - currentAge} lat!");
        else
            Console.WriteLine("Jesteś emerytem!");

        return;
    }
}