using System;

namespace TransformArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciation de notre manager
            TransformManager manager = new TransformManager();
            int[][] tableau = manager.CreerTableau();

            // Affichage du tableau
            manager.AfficherTableau(tableau);

            // Transformation
            manager.TransformerTableau(tableau);

            // Affichage du tableau
            manager.AfficherTableau(tableau);

            Console.ReadLine();
        }
    }
}
