using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int sum_num = 0; 
        int num_num = 0;
        // Loop
        //while (userNum != 0){
        Console.Write("Enter a number: ");
        string user_num = Console.ReadLine();
        int userNum = int.Parse(user_num);

        sum_num += userNum;
        num_num += 1;
        numbers.Add(userNum);
    }
    
}