using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phunog trinh bat hai: ");
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so c: ");
            double c = double.Parse(Console.ReadLine());
            double delta = 0, x = 0, x1 = 0, x2 = 0;
            string ket_qua = " ";
            if(a == 0)
            {
                if(b==0 && c == 0)
                {
                    ket_qua = "Vo so nghiem";
                    Console.WriteLine($"Phuong trinh {ket_qua}");
                }
                if(b==0 && c != 0)
                {
                    ket_qua = "Vo nghiem";
                    Console.WriteLine($"Phuogn trinh {ket_qua}");
                }
                if(b!=0 && c!=0)
                {
                    ket_qua = "Co nghiem";
                     x = -(c / b);
                    Console.WriteLine($"Phuong trinh {ket_qua} :\n{x}");
                }
            }
            if (a != 0)
            {
                if(b!=0 && c != 0)
                {
                    delta = Math.Pow(b, 2) - (4 * a * c);
                }
            }
            if(delta < 0)
            {
                ket_qua = "Vo nghiem";
            }
            if(delta == 0)
            {
                ket_qua = "Nghiem kep x1 = x2 = x";
                x = -b / 2 * a;
                Console.WriteLine($"Phuong trinh {ket_qua}\n{x}");
            }
            if(delta > 0)
            {
                ket_qua = "Co 2 nghiem phan biet x1 # x2";
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh {ket_qua}\n{x1}\n{x2}");
            }
            Console.ReadLine();
        }
    }
}
