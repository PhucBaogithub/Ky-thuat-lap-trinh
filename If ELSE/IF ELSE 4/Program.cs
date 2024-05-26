using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh tien dien: ");
            Console.ReadLine();
            Console.Write("Nhap chi so dien cu: ");
            double csc = double.Parse(Console.ReadLine());
            Console.Write("Nhap chi so dien moi: ");
            double csm = double.Parse(Console.ReadLine());
            double tcs = 0, td = 0;
            tcs = csm - csc;
            if(tcs > 0 && tcs <= 1000)
            {
                td = tcs * 250;
            }
            else
            {
                td = tcs * 750;
            }
            Console.WriteLine($"So tien dien phai tra: {td}");
            Console.ReadLine();
        }
    }
}
