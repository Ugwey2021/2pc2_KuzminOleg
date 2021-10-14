using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a =  new int[10];
            Console.Write("Исходный массив");
            for(int i=0; i < 10; i++)//Заполняем массив случайными цифрами
            {
                a[i] = rnd.Next(-10, 11);
                Console.Write(" "+a[i]);
            }
            Console.WriteLine();
            Console.Write("Результат");
            for (int i = 0; i < 10; i++)// делаем сдвиг
            {
                if(i != 9) a[i] = a[i + 1];
                else a[i] = 0;
                Console.Write(" " + a[i]);
            }
            
        }
    }
}
