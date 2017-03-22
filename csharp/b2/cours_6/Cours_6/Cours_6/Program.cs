using System;

namespace Cours_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 0 and 100 : (Validate by enter)");
            int value = int.Parse(Console.ReadLine());

            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine("Result :");

            Console.WriteLine(fizzBuzz.KataFb(value));

            Console.ReadLine();
        }
    }
}
