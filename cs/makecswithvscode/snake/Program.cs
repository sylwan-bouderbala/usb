using System;

namespace snake
{
    class Program
    {
        static int longfurtr
        static void affichercarte (int[,] carte)
        {
            for(int i=0; i<carte.GetLength(1); i++)
            {
                for (int j=0; j<carte.GetLength(0); j++)
                {
                    Console.Write(carte[i, j]);
                }
                Console.WriteLine();
            }
        }
        static int [,] creationmatrice()
        {
            int[,] mat = new int[15, 15];
            for (int i =0; i<mat.GetLength(1); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    mat[i, j] = 0;
                }

            }

            return mat;
        }
        static void Main(string[] args)
        {
            int[,] carte = creationmatrice();
            affichercarte(carte);
        }
    }
}
