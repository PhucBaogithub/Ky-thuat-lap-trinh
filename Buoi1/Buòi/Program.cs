using System;

namespace Buoi2
{
    class Program
    {
        static void TestSelectionSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.Xuat();
        }

        static void TestInterChangeSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>InterChangeSort Sort:");
            objTam.Xuat();
        }

        static void TestBubbleChangeSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.BubbleChangeSort();
            Console.WriteLine("\n>>BubbleChange Sort:");
            objTam.Xuat();
        }

        static void TestQuickSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.QuickSort();
            Console.WriteLine("\n>>Quick Sort:");
            objTam.Xuat();
        }

        static void TestInsertionSort(IntArray obj)
        {
            //Copy ojb sang objTam để sắp xếp
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.Xuat();
        }
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:");
            obj.Xuat();

            Console.Write("\n>>Gia tri can tim x = ");
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.TimTuanTu(x);
            if (kq == -1)
                Console.WriteLine("->Khong ton tai {0}!", x);
            else
                Console.WriteLine("->Co {0} tai vi tri {1}", x, kq);
        }
        //Test phương pháp tìm nhị phân
        static void TestTimNhiPhan()
        {
            IntArray a = new IntArray(15);
            a.Nhap();
            int value = a.TimNhiPhan(15);
            Console.WriteLine("Mang: ");
            a.Xuat();
            if (value == -1)
            {
                Console.WriteLine("Khong tim thay x: ");
            }
            else
            {
                Console.WriteLine($"Vi tri cua x la: a[{value}]");
            }
            Console.WriteLine("Mang da sap xep: ");
            a.Xuat();
        }

        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20);
            Console.WriteLine("Gia tri mang phat sinh: ");
            obj.Xuat();
        }
        static void TestConstructor2()
        {
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Gia tri mang: ");
            obj.Xuat();
        }
        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.WriteLine("Gia tri mang: ");
            obj1.Xuat();

            IntArray obj2 = new IntArray(obj1);

            Console.WriteLine("\nGia tri mang copy: ");
            obj2.Xuat();
        }
        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            //TestConstructor3();
            //TestTimTuanTu();
            //TestTimNhiPhan();
            //Console.WriteLine("Nhap k phan tu: ");
            //int k = int.Parse(Console.ReadLine());
            //IntArray objA = new IntArray(k);
            //objA.Xuat();
            //Console.WriteLine("Nhap gia tri can tim x: ");
            //int x = int.Parse(Console.ReadLine());
            //int value = objA.TimTuanTu(x);
            //if (x == -1)
            //    Console.WriteLine("->Khong ton tai {0}!", x);
            //else
            //    Console.WriteLine("->Co {0} tai vi tri {1}", x, value);
            //IntArray objB = new IntArray(k);
            //objB.Nhap();
            //objB.TimNhiPhan(x);
            //objB.TimTuanTu(x);
            IntArray obj = new IntArray(10);
            //TestSelectionSort(obj);
            //TestInterChangeSort(obj);
            //TestBubbleChangeSort(obj);
            //TestQuickSort(obj);
            //TestInsertionSort(obj);
        }
    }
}


