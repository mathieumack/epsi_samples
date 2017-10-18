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
            double value1 = 0;
            double value2 = 0;
            string line1 = "";
            string line2 = "";
            string line3 = "";

            bool tf = true;
            while (tf)
            {
                line1 = Console.ReadLine();
                // Traitement pour gérer la saisie sur une ligne :
                if (line1.Contains("+"))
                {
                    string[] line = line1.Split('+');
                    line1 = line[0];
                    line2 = "+";
                    line3 = line[1];
                }
                else if (line1.Contains("-"))
                {
                    string[] line = line1.Split('-');
                    line1 = line[0];
                    line2 = "-";
                    line3 = line[1];
                }
                else if (line1.Contains("*"))
                {
                    string[] line = line1.Split('*');
                    line1 = line[0];
                    line2 = "*";
                    line3 = line[1];
                }
                else if (line1.Contains("/"))
                {
                    string[] line = line1.Split('/');
                    line1 = line[0];
                    line2 = "/";
                    line3 = line[1];
                }

                // Lancement des calculs :
                try
                {
                    value1 = double.Parse(line1);
                    value2 = double.Parse(line3);

                    if (line2 != "+" && line2 != "-" && line2 != "*" && line2 != "/")
                        throw new InvalidOperationException();

                    tf = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Données invalides");
                }
            }
            CalculOperator add = new CalculOperator();
            if (line2 == "+")
            {
                double result = add.Calcul<Addition>(value1, value2);
                Console.WriteLine(result);
            }
            else if (line2 == "-")
            {
                double result = add.Calcul<Soustraction>(value1, value2);
                Console.WriteLine(result);
            }
            else if (line2 == "*")
            {
                double result = add.Calcul<Multiplication>(value1, value2);
                Console.WriteLine(result);
            }
            else if (line2 == "/")
            {
                double result = add.Calcul<Division>(value1, value2);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }

    public class CalculOperator
    {
        public double Calcul<T>(double a, double b) where T : ICalcul, new()
        {
            T monOprator = new T();
            return monOprator.DoOperation(a, b);
        }
    }

    public interface ICalcul
    {
        double DoOperation(double a, double b);
    }

    public class Addition : ICalcul
    {
        public double DoOperation(double a, double b)
        {
            return a + b;
        }
    }

    public class Soustraction : ICalcul
    {
        public double DoOperation(double a, double b)
        {
            return a - b;
        }
    }

    public class Multiplication : ICalcul
    {
        public double DoOperation(double a, double b)
        {
            return a * b;
        }
    }

    public class Division : ICalcul
    {
        public double DoOperation(double a, double b)
        {
            return a / b;
        }
    }
}
