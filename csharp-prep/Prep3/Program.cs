using System;


    static void Main(string[] args)
    {   
        Console.WriteLine(" What is the magic number?");
        int magicnumber = int.Parse(Console.ReadLine());
        Console.WriteLine(" What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        while(magicnumber != guess)
        {   
            Console.WriteLine(" What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if(guess < magicnumber){
                Console.WriteLine("Higher");
            }
            else if(guess > magicnumber){
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine($"yes! > {magicnumber} < is the magic number!");
        }
}