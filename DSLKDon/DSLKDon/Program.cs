using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    class Program
    {
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");           
            list.ShowList();
            Console.Write("Hay nhap x can tim vi tri: ");
            int x = int.Parse(Console.ReadLine());
            int searchx = list.SearchX(x);
            Console.WriteLine($"code Node X tai vi tri: {searchx}");
            list.GetEvenList();
            list.GetOddList();
            list.GetMax();
            list.GetMin();
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
