using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            
            int value1 = int.Parse(line1);
            int value2 = int.Parse(line3);

            if (line2 == "+")
            {
                Addition add = new Addition();
                double result = add.DoOperation(value1, value2);
                Console.WriteLine(result);
            }
            else if (line2 == "-")
            {
                Soustraction sous = new Soustraction();
                double result = sous.DoOperation(value1, value2);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
    
    public class Addition
    {
        public double DoOperation(double a, double b)
        {
            return a + b;
        }
    }

    public class Soustraction
    {
        public double DoOperation(double a, double b)
        {
            return a - b;
        }
    }

    public class Multiplication
    {
        public double DoOperation(double a, double b)
        {
            return a * b;
        }
    }

    public class Division
    {
        public double DoOperation(double a, double b)
        {
            return a / b;
        }
    }
}
