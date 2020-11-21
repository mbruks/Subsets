using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace subsets
{
    class Program
    {

        static void printSubSets(int numOfBits, int num, StreamWriter sw)
        {
            if (num >= 0)
            {
                sw.Write("{ ");
                subset(numOfBits - 1, num, numOfBits, sw);
                sw.WriteLine("}");
                printSubSets(numOfBits, num - 1, sw);
            }
            else
                return;
        }
        static void subset(int nthBit, int num, int numOfBits, StreamWriter sw)
        {
            if (nthBit >= 0)
            {
                if ((num & (1 << nthBit)) != 0)
                {
                    sw.Write(numOfBits - nthBit + " ");
                }  
                subset(nthBit - 1, num, numOfBits, sw);
            }
            else
                return;
        }
        public static void Main(String[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Admin\source\repos\ConsoleApp25\ConsoleApp25\txt.txt");
            //Время работы программы
            DateTime time1 = DateTime.Now;
            for (int i = 0; i < 200000000; i++) { }
            DateTime time2 = DateTime.Now;
            Console.WriteLine("Время выполнения: {0}", (time2 - time1).Milliseconds);
            Console.WriteLine("Введите число N = ");

            int n = int.Parse(Console.ReadLine());
            printSubSets(n, (int)(Math.Pow(2, n)) - 1, sw);
            sw.Close();
            Console.ReadKey();
        }

    }
}