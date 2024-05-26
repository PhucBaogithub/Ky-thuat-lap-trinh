using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_CASE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hay nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            string kq = " ";
            int thu = 0;
            if(thang < 3)
            {
                thang = thang + 12;
                nam = nam - 1;
            }
            thu = (ngay + (2 * thang) + 3 * (thang + 1) / 5 + nam + nam / 4) % 7;
            switch (thu)
            {
                case 0: kq = "Chu nhat";
                    break;
                case 1: kq = "Thu hai";
                    break;
                case 2: kq = "Thu ba";
                    break;
                case 3: kq = "Thu tu";
                    break;
                case 4: kq = "Thu nam";
                    break;
                case 5: kq = "Thu sau";
                    break;
                case 6: kq = "Thu bay";
                    break;
            }
            Console.WriteLine($"Hom do la ngay {kq}");
            Console.ReadLine();
        }
    }
}
