using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Student sv2 = new Student();

            sv2.InputInfo();
            Console.WriteLine();

            Console.WriteLine($"So tuoi cua {sv2.Name} la: {sv2.GetAge()}"); 
            Console.WriteLine();

            sv2.PrintInfo();
        }
    }
}
