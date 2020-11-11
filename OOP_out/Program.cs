using System;

namespace OOP_out
{
    class Program
    {
        static void printName(out string strName)
        {
            strName = "Ahmad";
            Console.WriteLine("Hallo" +" "+ strName);
        }
        static void Main(string[] args)
        {
           
            string myName;
            printName(out myName);
            Console.ReadKey();
        }
    }
}
