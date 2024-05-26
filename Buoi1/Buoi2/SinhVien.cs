using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class SinhVien
    {
        public string maSo;
        public string hoTen;
        public string chuyenNganh;
        public int namSinh;
        public float diemTB;
        public string loai;

        //Constructor
        public SinhVien() { }
        public SinhVien(SinhVien sv)
        {
            maSo = sv.maSo;
            hoTen = sv.hoTen;
            chuyenNganh = sv.chuyenNganh;
            namSinh = sv.namSinh;
            diemTB = sv.diemTB;
            loai = sv.loai;
        }
        //public void Copy(SinhVien sv)
        //{
        //    maSo = sv.maSo;
        //    hoTen = sv.hoTen;
        //    chuyenNganh = sv.chuyenNganh;
        //    namSinh = sv.namSinh;
        //    diemTB = sv.diemTB;
        //    loai = sv.loai;
        //}
        public SinhVien(string ms, string ht, string cn, int ns, float dtb)
        {
            maSo = ms;
            hoTen = ht;
            chuyenNganh = cn;
            if (DateTime.Now.Year - ns >= 17 && DateTime.Now.Year - ns <= 70)
            {
                namSinh = ns;
            }
            if (dtb >= 0 && dtb <= 10)
            {
                diemTB = dtb;
            }
            XepLoai();
        }
        public void XepLoai()
        {
            if (diemTB < 5)
            {
                loai = "Kem";
            }
            if (diemTB >= 5 && diemTB < 7)
            {
                loai = "Trung Binh";
            }
            if (diemTB >= 7 && diemTB < 8)
            {
                loai = "Kha";
            }
            else
            {
                loai = "Gioi";
            }
        }

        public void setmaSo(string maSo) { this.maSo = maSo; }
        public void sethoTen(string hoTen) { this.hoTen = hoTen; }
        public void setchuyenNganh(string chuyenNganh) { this.chuyenNganh = chuyenNganh; }
        public void setnamSinh(int namSinh) { this.namSinh = namSinh; }
        public void setdiemTB(float diemTB) { this.diemTB = diemTB; }
        public void setloai(string loai) { this.loai = loai; }

        public string getmaSo() { return maSo; }
        public string gethoTen() { return hoTen; }
        public string getchuyenNganh() { return chuyenNganh; }
        public int getnamSinh() { return namSinh; }
        public float getdiemTB() { return diemTB; }
        public string getloai() { return loai; }

        public bool KiemTraNamSinh(int ns)
        {
            if (DateTime.Now.Year - ns >= 17 && DateTime.Now.Year - ns <= 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KiemTraDiemTB(float dtb)
        {
            if (dtb >= 0 && dtb <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Nhap()
        {
            Console.Write("Hay nhap Ma So: ");
            maSo = Console.ReadLine();
            Console.Write("Hay nhap Ho va Ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Hay nhap Chuyen Nganh: ");
            chuyenNganh = Console.ReadLine();
            Console.Write("Hay nhap Nam Sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            while (DateTime.Now.Year - namSinh <= 17 && DateTime.Now.Year - namSinh > 70)
            {
                Console.Write("Ban nhap sai moi nhap lai: ");
                namSinh = int.Parse(Console.ReadLine());
            }
            Console.Write("Hay nhap Diem Trung Binh: ");
            diemTB = float.Parse(Console.ReadLine());
            while (diemTB < 0 || diemTB > 10)
            {
                diemTB = float.Parse(Console.ReadLine());
            }
            XepLoai();
        }
        public void Xuat()
        {
            Console.WriteLine($"Sinh Vien[Ma so:{maSo}, Ho va Ten:{hoTen}, Chuyen Nganh:{chuyenNganh}, Nam Sinh:{namSinh}, Diem Trung Binh:{diemTB}, Xep Loai:{loai}]");
        }

    }
}
