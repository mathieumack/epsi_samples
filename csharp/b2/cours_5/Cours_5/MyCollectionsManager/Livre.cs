using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsManager
{
    class Livre : Item
    {
        public override void Edit(string nom, double test)
        {
            Console.WriteLine("Entrez le nom :");
            Title = Console.ReadLine();

            Console.WriteLine("Entrez les propriétés (tapez exit pour arréter) :");
            string valeur = "";
            while (valeur != "exit")
            {
                Property propriete = new Property();
                Console.WriteLine("Entrez le nom de la propriété :");
                propriete.Name = Console.ReadLine();
                Console.WriteLine("Entrez la valeur de la propriété :");
                propriete.Value = Console.ReadLine();
                Properties.Add(propriete);
                Console.WriteLine("Continuer ?");
                valeur = Console.ReadLine();
            }
        }

        public override void ShowDetail()
        {
            Console.WriteLine("     Titre : " + Title);
            Console.WriteLine("     Propriétés : ");
            foreach(string prop in Properties.Select(e => "     - : " + e.Name + " : " + e.Value))
                Console.WriteLine(prop);
        }
    }
}
