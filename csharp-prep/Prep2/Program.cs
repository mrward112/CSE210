using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your current grade percentage? ");
        string userInputGrade = Console.ReadLine();
        int Grade = int.Parse(userInputGrade);

    //Test for letter grade

        if (Grade >= 90)
        {
            Console.WriteLine("your grade is an A. Good job!");
        }
        else if (Grade >= 80)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (Grade >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (Grade >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else 
        {
            Console.WriteLine("Your grade is an F. Try retaking the class");
        }


    //Test for passing grade
        if (Grade >= 70)
        {
            Console.WriteLine("You have passed the class! ");
        }

        else
        {
            Console.WriteLine("You did not pass the class. ");
        }

    }
}