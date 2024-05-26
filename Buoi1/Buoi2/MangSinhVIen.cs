using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
     class MangSinhVien
    {
        private SinhVien[] a;
        private string msx;
        private int vt;
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
            a = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}: ");
                    a[i] = new SinhVien();
                    a[i].Nhap();

                    if (TonTai(a[i].maSo, i))
                    {
                        Console.WriteLine("Ma so sinh vien da ton tai. Vui long nhap lai");
                    }
                    else
                    {
                        break;
                    }

                } while (true);
                Console.WriteLine();
            }
        }
        public void XuatMang()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Sinh viên thứ {i}:");
                a[i].Xuat();
            }

            //foreach (SinhVien sv in a)
            //    sv.Xuat();
        }

        public SinhVien[] A
        {
            get { return a; }
            set { a = value; }
        }
        public bool TonTai(string msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (a[i].maSo.CompareTo(msx) == 0)
                    return true;
            }
            return false;
        }
        public void SelectionSort()
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].hoTen.Length < a[min].hoTen.Length)
                    {
                        Swap(ref a[min], ref a[j]);
                    }
                    Swap(ref a[min], ref a[i]);
                }
            }
        }
        static void Swap(ref SinhVien a, ref SinhVien b)
        {
            SinhVien c = new SinhVien(a);
            //c.Copy(a);
            //a.Copy(b);
            //b.Copy(c);
            a = new SinhVien(b);
            b = c;
        }
    }
}
