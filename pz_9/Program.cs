using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 15;
            int[] end = { 0, 0 };
            Random rnd = new Random();
            Console.WriteLine("Введите количество строк: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int b = int.Parse(Console.ReadLine());
            int[,] A = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    A[i, j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine("Получившийся массив:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(A[i, j]+" ");
                }
                Console.WriteLine();
            }
           

                for (int i = 0; i < a; i++)
                {
                        min = A[i, 0];
                        for (int j = 0; j < b; j++)
                        {
                        if (A[i, j] < min)
                        {
                            min = A[i, j];
                            end[0] = i;
                            end[1] = j;
                        }
                        }
                for (int i1 = 0; i1 < a; i1++)
                {
                    if (A[i1, end[1]] < min)
                    {
                        min = A[i1, end[1]];
                        end[0] = i1;
                    }
                }
                Console.WriteLine("Итог"+end[0]+" "+end[1]);
                }
        }
    }
}
