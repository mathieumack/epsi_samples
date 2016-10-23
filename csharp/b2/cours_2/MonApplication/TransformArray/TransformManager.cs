using System;

namespace TransformArray
{
    public class TransformManager
    {
        public int[][] CreerTableau()
        {
            int[][] tableau = new int[10][];
            for (int i = 0; i < 10; i++)
            {
                tableau[i] = new int[10];
                for (int j = 0; j < 10; j++)
                    tableau[i][j] = j;
            }

            return tableau;
        }

        public void AfficherTableau(int[][] tableau)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tableau[i][j]);
                }
                Console.Write(Environment.NewLine);
            }
        }

        public void TransformerTableau(int[][] tableau)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    int value = tableau[i][j];
                    tableau[i][j] = tableau[j][i];
                    tableau[j][i] = value;
                }
            }
        }
    }
}