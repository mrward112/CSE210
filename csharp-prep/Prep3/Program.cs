using System;

class Program
{
    static void Main(string[] args)
    {
        //Get magic number
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        string user_Magic_Number = Console.ReadLine();
        int magic_Number = int.Parse(user_Magic_Number);

        int user_Number = -1;

        //Loop function
        while (user_Number != magic_Number)
        {
  
        //Get user guesss
            Console.Write("What is your guess? ");
            user_Number = int.Parse(Console.ReadLine());
            //int user_Number = int.Parse(user_Magic_Guess);


        //Statement test
            if (user_Number == magic_Number)
            {
                Console.WriteLine("You guessed the magic number! ");

            }
            else if (user_Number > magic_Number)
            {
                Console.WriteLine("Lower ");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("higher ");
                Console.WriteLine("");

            }

        }

    //Console.Write($"It took you {count} guesses to get the magic number! ");
    
    }
}