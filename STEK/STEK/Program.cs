using System;
using System.Collections.Generic;

namespace STEK
{
    class Program
    {
        
           private static int[,] matrix;
        private int color;

        private static int N;


        static Class1<KeyValuePair<int, int>> stack = new Class1<KeyValuePair<int, int>>();

        public static void Main(string[] args)
        {
            CreateMatrix(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("До:");
            ShowMatrix(matrix);
            Console.WriteLine("После:");
            FillMatrix(matrix, 2, 2);
            ShowMatrix(matrix);
            Count(matrix);
            Console.ReadLine();
        }

        static void CreateMatrix(int N)
        {
            matrix = new int[N, N];
            Random rnd = new Random(4);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Convert.ToInt32(rnd.Next(0, 4)) == 3)
                        matrix[i, j] = 1;
                }
            }
        }

        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void FillMatrix(int[,] matrix, int x, int y)
        {
            const byte c = 2;
            stack.Push(new KeyValuePair<int, int>(x, y));
            while (!stack.IsEmpty())
            {
                var tmp = stack.Peek();
                stack.Pop();
                if (tmp.Key >= 0 && tmp.Value >= 0 && tmp.Key < matrix.GetLength(0) && tmp.Value < matrix.GetLength(0) && matrix[tmp.Key, tmp.Value] == 0)
                {
                    matrix[tmp.Key, tmp.Value] = c;

                    stack.Push(new KeyValuePair<int, int>(tmp.Key, tmp.Value - 1));
                    stack.Push(new KeyValuePair<int, int>(tmp.Key - 1, tmp.Value));
                    stack.Push(new KeyValuePair<int, int>(tmp.Key, tmp.Value + 1));
                    stack.Push(new KeyValuePair<int, int>(tmp.Key + 1, tmp.Value));
                }
            }
        }

        static void Count(int[,] matrix)
        {
            byte a = 0;
            byte b = 0;
            byte c = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 1)
                        a++;
                    if (matrix[i, j] == 2)
                        b++;
                    if (matrix[i, j] == 0)
                        c++;
                }
            }

            Console.WriteLine("Кол-во Единиц: " + a);
            Console.WriteLine("Кол-во Двоек: " + b);
            Console.WriteLine("Кол-во Нулей: " + c);
            Console.WriteLine();
        }
    }
    
}
