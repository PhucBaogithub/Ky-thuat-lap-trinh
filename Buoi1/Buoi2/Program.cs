using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Program
    {
        static void TestMangSinhVien()
        {
            MangSinhVien dssv = new MangSinhVien();
            dssv.NhapMang();
            Console.WriteLine("Danh sach sinh vien:");
            dssv.XuatMang();
            dssv.SelectionSort();
            Console.WriteLine("Mang sinh vien sau khi sap xep: ");
            dssv.XuatMang();
        }
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.WriteLine("Thong tin sinh vien A:");
            svA.Xuat();
            SinhVien svB = new SinhVien("18DH00100", "Lam Thanh Ngoc", "CNPM", 2000, 7.6F);
            svB.Xuat();
            SinhVien svC = new SinhVien(svB);
            svC.sethoTen("Huynh Phuc Bao");
            svC.setdiemTB(10);
            svC.Xuat();
            svB.Xuat();
        }
        static void Main(string[] args)
        {
            //TestSinhVien();
            TestMangSinhVien();
        }
    }
}
