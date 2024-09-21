using System;

class Program{

    static void Main(string[] args)
    {  
        string option;
        do{
        int attempts = 0;
        Random randomGenerator = new Random();
        int Magicnumber = randomGenerator.Next(1, 11);
        Console.WriteLine(" What is your guess?");
        int guess = int.Parse(Console.ReadLine());
        if(guess < Magicnumber)
        { 
           Console.WriteLine("Higher");
           attempts++;
        }
        else if(guess > Magicnumber)
        {
           Console.WriteLine("Lower");
           attempts++;
        }

        while(Magicnumber != guess)
        {   
            Console.WriteLine(" What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if(guess < Magicnumber){
                Console.WriteLine("Higher");
                attempts++;
            }
            else if(guess >Magicnumber){
                Console.WriteLine("Lower");
                attempts++;
            }
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"you did {attempts} attempts!");
        Console.WriteLine("Do you wanna play again?(yes/no)");
        option = Console.ReadLine().ToLower();
        }while(option == "yes");
    }
}