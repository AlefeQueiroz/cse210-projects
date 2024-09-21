using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   int Sum = 0;
        int average = 0;
        int Count = 0;
        int max = 0;
        List <int> Numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true){
        int Number = int.Parse(Console.ReadLine());
        Sum = Sum + Number;
        Count++;
        if(max < Number){
            max = Number;
        }
        if(Number == 0){
            break;
        }
        Numbers.Add(Number);
        }
    average = Sum / (Count - 1);
    Console.WriteLine($"The sum is: {Sum}");
    Console.WriteLine($"The average is:{average}");
    Console.WriteLine($"The max is:{max}");
    Console.WriteLine($"Count is:{Count - 1}");

    }
}
