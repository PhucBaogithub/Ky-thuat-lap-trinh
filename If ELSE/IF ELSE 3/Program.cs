using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ho_ten = " ";
            int ngay_cong = 0;
            int so_con = 0;
            double ty_lebh = 0;
            int luong_ngay_cong = 0;
            double bao_hiemxg = 0;
            int phu_cap = 0;
            double tienlinh = 0;
            Console.WriteLine("Nhap ho ten: ");
            ho_ten = Console.ReadLine();
            Console.WriteLine("Nhap ngay cong: ");
            ngay_cong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so con: ");
            so_con = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ty le bao hiem: ");
            ty_lebh = double.Parse(Console.ReadLine());
            luong_ngay_cong = ngay_cong * 50000;
            bao_hiemxg = (double)luong_ngay_cong * ty_lebh;
            phu_cap = so_con * 100000;
            tienlinh = (double)luong_ngay_cong + (double)phu_cap - bao_hiemxg;
            Console.WriteLine($"So tien duoc lanh: {tienlinh}");
            Console.ReadLine();
        }
    }
}
