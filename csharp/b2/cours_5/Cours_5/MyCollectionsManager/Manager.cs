using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCollectionsManager
{
    public class Manager<T> where T : IEditable, new()
    {
        System.Collections.Generic.List<T> Items { get; set; }

        public Manager()
        {
            Items = new System.Collections.Generic.List<T>();
        }

        public void Ajouter()
        {
            T newItem = new T();
            Items.Add(newItem);
            newItem.Edit();
        }

        public void Editer()
        {
            Console.WriteLine("Quel est le numéro ?");
            int numero = int.Parse(Console.ReadLine());
            T element = Items[numero];
            element.Edit("Bonjour", 2);
        }

        public void AfficherListe()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                T element = Items[i];
                if (element is Livre)
                    Console.WriteLine("Livre " + i);
                else if (element is Film)
                {
                    Film film = element as Film;
                    Console.WriteLine("Film (" + film.DateSortie + ")" + i);
                }
                element.ShowDetail();
            }
        }
    }
}