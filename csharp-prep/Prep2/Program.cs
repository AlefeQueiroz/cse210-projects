using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Type your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90 )
        {   
            Console.WriteLine("Your final grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your final grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your final grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your final grade is: D");
        }
        else{
            Console.WriteLine("Your final grade is: F");
        }
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!!!");
        }
        else{
            Console.WriteLine("you did not meet the College grade requeriments.");
        }
    }  
}