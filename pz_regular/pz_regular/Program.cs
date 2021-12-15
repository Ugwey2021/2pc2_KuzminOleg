using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace pz_regular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            string text = "12-45-78;19-23-67;234-56-78;84-98-23";
            string[] ot = Regex.Split(text, ";");
            for (int i = 0; i < ot.Length; i++)
            {
                if (Regex.IsMatch(ot[i], @"\d{2}(-\d\d){2}")&&ot[i].Length<9)
                {
                    Match [] ogt = { Regex.Match(ot[i], @"\d{2}"),Regex.Match(ot[i],@"(-\d\d){2}")};
                    ot[i] = Regex.Replace(ot[i],ogt[0].ToString(),ogt[0].ToString()+"0");
                    Console.WriteLine(ot[i]);
                }
                else Console.WriteLine(ot[i]);
            }
            Console.WriteLine("Задание 2");
            string text1 = "telephone_faxometr";
            Console.WriteLine("Старый текст   "+text1);
            text1 = Regex.Replace(text1, "tel|tel:", "");
            text1 = Regex.Replace(text1, "fax:|fax","");
            Console.WriteLine("Новый текст   "+text1);
            Console.WriteLine("Задание 3");
            string result = "";
            string[] num3 = File.ReadAllLines("C:\\pz\\3.txt");
            for (int i = 0; i < num3.Length; i++)
            {
                if (Regex.IsMatch(num3[i],@"[1-31]-[1-12]-\d")||Regex.IsMatch(num3[i],@"[0-23]-[0-60]")||Regex.IsMatch(num3[i], @"[0-23]:[0-60]")||Regex.IsMatch(num3[i],@"\d{1,}")) result += num3[i]+"\n";
            }
            Console.WriteLine(result);
            Console.WriteLine("Задание 4");
            string[] num4 = File.ReadAllLines("C:\\pz\\connects.log.txt");
            for (int i = 0; i < num4.Length; i++)
            {
                string ip = "";
                string date = "";
                ip += Regex.Match(num4[i], @"\d{1,}\.\d{1,}\.\d{1,}\.\d{1,}");
                Console.WriteLine("IP:" + ip);
                date += Regex.Match(num4[i], @"29/[A-Z][a-z][a-z]/\d{4}");//[JanFebMarchAprMayJunJulAugSepOctNovDec]
                Console.WriteLine("Date:" + date);
            }
        }
    }
}
