using System;

class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        // Console.WriteLine("What is the magic number?");
        // string magicNum = Console.ReadLine();
        // int number = int.Parse(magicNum);

while (correct == false){

        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int test = int.Parse(guess);

        

        if (test < number){
            Console.WriteLine("Higher");
            Console.WriteLine(" ");
            //correct = false;
        }

        else if (test > number){
            Console.WriteLine("Lower");
            Console.WriteLine(" ");
            //correct = false;
        }

        else{
            Console.WriteLine("Correct!");
            correct = true;
        }
        }
    }
}