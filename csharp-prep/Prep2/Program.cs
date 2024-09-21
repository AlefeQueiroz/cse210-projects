using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   string letter = "";
        string sign = "";
        Console.WriteLine("Type your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90 )
        {   letter = "A";

        }
        else if (grade >= 80)
        {   letter = "B";
    
        }
        else if (grade >= 70)
        {   letter = "C";

        }
        else if (grade >= 60)
        {   letter = "D";

        }
        else{
            letter = "F";
        }
        if (grade % 10 <= 3)
        {
            sign = "-";
        }
        else if (grade % 10 >= 7)
        {
            sign = "+";
        }
        if (grade <= 60 || grade >= 97){
            sign = "";
        }
        Console.WriteLine($"Your Grade is: {letter} {sign}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!!");
        }
        else{
            Console.WriteLine("you did not meet the College grade requeriments.");
        }
    }  
}