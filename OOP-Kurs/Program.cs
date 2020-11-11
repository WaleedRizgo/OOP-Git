using System;

namespace OOP_Kurs
{
    class Program
    {
        static void printNUM(ref int num)
        {
            num = 10;
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int x = 70;
            Console.WriteLine("X before REF" + x);
            printNUM(ref x);
            Console.WriteLine("X after REF" + x);
            Console.ReadKey();
        }
    }
}
