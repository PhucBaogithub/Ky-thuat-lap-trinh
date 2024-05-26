using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so thu trong tuan tu 2 den 8: ");
            int thu = int.Parse(Console.ReadLine());
            switch (thu)
            {
                case 2: Console.WriteLine("Thu 2");
                    break;
                case 3:
                    Console.WriteLine("Thu 3");
                    break;
                case 4:
                    Console.WriteLine("Thu 4");
                    break;
                case 5:
                    Console.WriteLine("Thu 5");
                    break;
                case 6:
                    Console.WriteLine("Thu 6");
                    break;
                case 7:
                    Console.WriteLine("Thu 7");
                    break;
                case 8:
                    Console.WriteLine("Thu chu nhat");
                    break;
            }
            Console.ReadLine();
        }
    }
}
