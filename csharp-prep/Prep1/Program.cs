using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        string first = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        string second = Console.ReadLine();

        Console.WriteLine($"Your name is {second}, {first} {second}.");
    }
}