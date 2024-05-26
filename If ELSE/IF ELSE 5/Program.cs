using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long hc = 0, ht = 0, hw = 0;
            Console.Write("Gio TpHCM: ");
            hc = int.Parse(Console.ReadLine());
            if(hc >= 0 && hc < 12)
            {
                hw = hc + 12;
                Console.Write($"Gio Washington: {hw}, ngay truoc");
            }
            if (hc >= 12 && hc < 23)
            {
                hw = hc - 12;
                Console.Write($"Gio Washington: {hw}, cung ngay");
            }
            Console.WriteLine();
            if(hc >= 0 && hc < 22)
            {
                ht = hc + 2;
                Console.Write($"Gio Tokyo: {ht}, cung ngay");
            }
            if (hc >= 22 && hc <= 23)
            {
                ht = hc - 22;
                Console.Write($"Gio Tokyo: {ht}, ngay hom sau");
            }
            Console.ReadLine();
        }
    }
}
