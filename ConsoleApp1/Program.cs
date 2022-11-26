using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Roma";
            Console.WriteLine(MyName);
            Console.WriteLine("\t Привет, \nмир!");
            Console.WriteLine("\t Мне 28 лет");
            Console.WriteLine("\t My name is \n Roma");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(5);
            
            Console.ReadKey();
        }
    }
}
