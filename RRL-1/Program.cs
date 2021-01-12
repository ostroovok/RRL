using System;

namespace RRL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3, 5, 3, }, { 3, 8, 9, 8, 1 }, { 23, 45, 67, 1, 2 }, { 1, 2, 3, 5, 7 } };
            int[,] B = new int[4, 5];
            int rows = A.GetUpperBound(0) + 1;
            int columns = A.Length / rows;
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //A[i, j] = rnd.Next(0, 100);
                    B[i, j] = 0;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < columns - 1; j++)
                {
                    if (Math.Abs(A[i, j - 1] - A[i, j]) == 1)
                    {
                        if (Math.Abs(A[i, j + 1] - A[i, j]) == 1)
                        {
                            B[i, j] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{A[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{B[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
