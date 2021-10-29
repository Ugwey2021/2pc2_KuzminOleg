using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] last = new int[20];
            int[][] num = new int[2][];
            num[0] = new int[5];
            num[1] = new int[rnd.Next(4, 20)];
            for (int i = 0; i < 5; i++)
            {
                num[0][i] = rnd.Next(0, 10);
                if (i < 4) Console.Write(num[0][i] + ",");
                else Console.Write(num[0][i]);
            }
            Console.WriteLine();
            for (int i = 0; i < num[1].Length; i++)
            {
                num[1][i] = rnd.Next(1, 10);
                if (i < num[1].Length - 1) Console.Write(num[1][i] + ",");
                else Console.Write(num[1][i]);
            }
            Console.WriteLine();
            last[2] = num[0][4];
            last[3] = num[1][num[1].Length-1];
            Console.WriteLine("Последние символы: " + last[2] + "," + last[3]);
            last[2] = num[0].Max();
            last[3] = num[1].Max();
            Console.WriteLine("Максимиальные элементы массивов: " + last[2] + "," + last[3]);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    if (last[2] == num[i][j])
                    {
                        if (i == 0)
                        {
                            last[9] = i;
                            last[10] = j;
                        }
                        else
                        {
                            last[11] = i;
                            last[12] = j;
                        }
                    }
                }
            }
            last[0] = num[last[9]][last[10]];
            last[1] = num[last[11]][last[12]];
            num[last[9]][last[10]] = num[0][0];
            num[last[11]][last[12]] = num[1][0];
            num[0][0] = last[0];
            num[1][0] = last[1];
            Console.WriteLine("Обновленный массив");
            for (int i = 0; i < 5; i++)
            {
                if (i < 4) Console.Write(num[0][i] + ",");
                else Console.WriteLine(num[0][i]);
            }
            for (int i = 0; i < num[1].Length; i++)
            {
                if (i < num[1].Length) Console.Write(num[1][i] + ",");
                else Console.WriteLine(num[1][i]);
            }
        }
    }
}


