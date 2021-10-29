using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] last = new int[9];
            int[][] num = new int[2][];
            num[0] = new int[5];
            num[1] = new int[rnd.Next(4,20)];
            for (int i = 0; i < 5; i++)
            {
                num[0][i] = rnd.Next(0, 10);
                if (i < 4) Console.Write(num[0][i] + ",");
                else Console.Write(num[0][i]);
            }
            Console.WriteLine();
            for(int i = 0; i < num[1].Length; i++)
            {
                num[1][i] = rnd.Next(1, 10);
                if (i < num[1].Length-1) Console.Write(num[1][i] + ",");
                else Console.Write(num[1][i]);
            }
            Console.WriteLine();
            last[0] = num[0][4];
            Console.Write("Последние символы строк: " + last[0] + ",");
            last[1] = num[1][num[1].Length-1];
            Console.WriteLine(last[1]);
            last[2] = num[0].Max();
            last[3] = num[1].Max();
            Console.WriteLine("Максимиальные элементы массивов: "+last[2]+","+last[3]);
            Console.WriteLine("Обновленный массив");
            last[5] = num[0][0];
            last[6] = num[0][4];
            num[0][0] = last[6];
            num[0][4] = last[5];
            last[7] = num[1][0];
            last[8] = num[1][num[1].Length-1];
            num[1][0] = last[8];
            num[1][num[1].Length - 1] = last[7];
            for(int i =0;i<5;i++)
            {
                if (i < 4) Console.Write(num[0][i] + ",");
                else Console.WriteLine(num[0][i-1]);
            }
            for(int i = 0;i<num[1].Length;i++)
            {
                if (i < num[1].Length - 1) Console.Write(num[1][i] + ",");
                else Console.WriteLine(num[1][i]);
            }
        }
    }
}
