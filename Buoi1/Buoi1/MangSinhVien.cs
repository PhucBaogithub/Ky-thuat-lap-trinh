using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    class MangSinhVien
    {
        private SinhVien[] a;
        public MangSinhVien()
        {
            a = new SinhVien[0];
        }
        public MangSinhVien(int n)
        {
            a = new SinhVien[n];
        }
        public void NhapMang()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            while(n <= 0 || n > 1000000)
            {
                n = int.Parse(Console.ReadLine());
            }
            a = new SinhVien[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new SinhVien();
                a[i].Nhap();
            }
        }
        public void XuatMang()
        {
            for(int i = 0; i < a.Length; i++)
            {
                a[i].Xuat();
            }

            foreach (SinhVien sv in a)
                sv.Xuat();
        }

        public SinhVien[] A
        {
            get { return a; }
            set { a = value; }
        }
    }
}
