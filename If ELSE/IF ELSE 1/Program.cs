using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phunog trinh bat nhat: ");
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());
            if (a ==0 && b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem!");
            }
            if(a==0 && b !=0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
            if(a != 0 && b != 0)
            {
                double kq = -b / a;
                Console.WriteLine($"nghiem cua phuong trinh la {kq}");
            }
            Console.ReadLine();
        }
    }
}
