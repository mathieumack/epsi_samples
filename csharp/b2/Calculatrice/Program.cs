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
                // TODO : Ajouter ici le traitement pour les autres opérations :

                // Lancement des calculs :
                try
                {
                    value1 = double.Parse(line1);
                    value2 = double.Parse(line3);

                    if (line2 != "+" && line2 != "-")
                        throw new InvalidOperationException();

                    tf = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Données invalides");
                }
            }
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
}
