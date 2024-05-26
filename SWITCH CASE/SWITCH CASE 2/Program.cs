using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_CASE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime ngay;
            string thu_trong_tuan = "";
            Console.WriteLine("nhap ngay thang nam kieu thang/ngay/nam");
            ngay = DateTime.Parse(Console.ReadLine());
            switch (ngay.DayOfWeek)
            {
                case DayOfWeek.Monday: thu_trong_tuan = "thu hai"; break;
                case DayOfWeek.Tuesday: thu_trong_tuan = "thu ba"; break;
                case DayOfWeek.Thursday: thu_trong_tuan = "thu tu"; break;
                case DayOfWeek.Wednesday: thu_trong_tuan = "thu nam"; break;
                case DayOfWeek.Friday: thu_trong_tuan = "thu sau"; break;
                case DayOfWeek.Saturday: thu_trong_tuan = "thu bay"; break;
                case DayOfWeek.Sunday: thu_trong_tuan = "thu chu nhat"; break;
            }
            Console.WriteLine($"ngay {ngay.ToString("dd/MM/yyyy")} la: {thu_trong_tuan}");
        }
    }
}
