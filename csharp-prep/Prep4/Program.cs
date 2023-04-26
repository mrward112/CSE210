using System;

class Program
{
    static void Main(string[] args)
    {
        //Intro
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int user_Input_Number = 99999;

         //List
        List<int> numbers = new List<int>();

        //loop
        while (user_Input_Number != 0)
        {
            //User input and addition to the list
            Console.WriteLine("Enter number: ");
            user_Input_Number = int.Parse(Console.ReadLine());

            numbers.Add(user_Input_Number);
        }

        //calculations
        int sum = 0;
        int maximum = numbers[0];
        float average = 0;

        foreach (int number in numbers)
        {
            //sum
            sum += number;

            //average
            average = ((float)sum) / numbers.Count;


            //maximum
            if (number > maximum)
            {
                maximum = number;
            }
        }
            //Display output
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The maximum is: {maximum}");

    }
}