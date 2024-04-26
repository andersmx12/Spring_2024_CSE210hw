using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";


        if (number >= 90){
            // Console.WriteLine("You have an A");
            letter = "A";
        }
        else if (number >= 80 && number < 90){
            //Console.WriteLine("You have a B");
            letter = "B";
        }
        else if (number >= 70 && number < 80){
            //Console.WriteLine("You have a C");
            letter = "C";
        }
        else if (number >= 60 && number < 70){
            //Console.WriteLine("You have a D");
            letter = "D";
        }
        else if (number < 60){
            Console.WriteLine("You are failing.");
        }
        else {
            Console.WriteLine("That value is our of range.");
        }

        if (number >= 70){
            Console.WriteLine($"You have a(n) {letter}! You are passing!");
        }
        else {
            Console.WriteLine("You are failing");
        }
    }
}