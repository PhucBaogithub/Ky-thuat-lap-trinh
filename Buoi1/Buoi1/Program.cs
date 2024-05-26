using System;

namespace Buoi1
{
    class Program
    {
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.WriteLine("Thong tin sinh vien A:");
            svA.Xuat();
            SinhVien svB = new SinhVien("18DH001","Lam Thanh Ngoc","CNPM", 2000, 7.6F);
            svB.Xuat();
            SinhVien svC = new SinhVien(svB);
            svC.sethoTen("Huynh Phuc Bao");
            svC.setdiemTB(10);
            svC.Xuat();
            svB.Xuat();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
