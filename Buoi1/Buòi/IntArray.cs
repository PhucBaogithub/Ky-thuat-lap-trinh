using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2
{
    class IntArray
    {
        private int[] array;
        public IntArray() { }
        public IntArray(int k) 
        {
            while(KiemTraKT(k) != true)
            {
                Console.Write("Moi nhap lai nha em: ");
                k = int.Parse(Console.ReadLine());
            }
            array = new int[k];
            Random rnd = new Random();
            for(int i =0; i< array.Length; i++)
            {
                int num = rnd.Next(1, 200);
                array[i] = num;
            }
        }
        public IntArray(int[] a) 
        {
            array = a;
        }
        public IntArray(IntArray obj) 
        {
            array = obj.array;
        }
        public bool KiemTraKT(int n)
        {
            if(n > 0 && n < 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setArray()
        {
            Console.Write("Nhap kich thuoc cua mang: ");
            int n = int.Parse(Console.ReadLine());
            while (KiemTraKT(n) != true)
            {
                Console.Write("Moi nhap lai nha em: ");
                n = int.Parse(Console.ReadLine());
            }
            array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public int[] getArray()
        {
            return array;
        }
        public void Nhap()
        {
            Console.Write("Nhap kich thuoc cua mang: ");
            int n = int.Parse(Console.ReadLine());
            while (KiemTraKT(n) != true)
            {
                Console.Write("Moi nhap lai nha em: ");
                n = int.Parse(Console.ReadLine());
            }
            array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Mang: ");
            for(int i = 0; i< array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public int TimTuanTu(int x)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x)
                    return i;
            }
            return -1;
        }
        public int TimNhiPhan(int x)
        {   
            for(int i = 0; i< array.Length; i++)
            {
                for(int j = array.Length -1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("Nhap x can tim vi tri: ");
            x = int.Parse(Console.ReadLine());
            int left = 0;
            int right = array.Length - 1;
            int mid = (left + right) / 2;
            while (left < right)
            {
                if (array[mid] == x)
                {
                    return mid;
                }
                if (array[mid] > x)
                {
                    right = mid - 1;
                    mid = (left + right) / 2;
                }
                if (array[mid] < x)
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }
            }
            return -1;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void SelectionSort()
        {
            for(int i = 0; i < array.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[min])
                    {
                        Swap(ref array[min], ref array[j]);
                    }
                    Swap(ref array[min], ref array[i]);
                }
            }
        }
         public void InterchangeSort()
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }
        public void BubbleChangeSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j-1]) 
                    {
                        Swap(ref array[j], ref array[j - 1]);
                    }                  
                }
            }
        }
        public void InsertionSort()
        {
            for(int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while(j>=0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = temp; 
            }
        }
        static int _choosePivot(int[] array, int l, int r)
        {

            return (l + r) / 2;
        }
        static int _partition(int[] array, int l, int r)
        {
            int pi = _choosePivot(array, l, r);
            if (pi >= 0)
            {
                Swap(ref array[pi], ref array[r]);
                pi = l;
                for (int i = l; i < r; i++)
                {
                    if (array[i] <= array[r])

                    {

                        Swap(ref array[i], ref array[pi]);

                        pi++;

                    }
                }
                Swap(ref array[pi], ref array[r]);
            }
            return pi;
        }
        public void _quickSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                int p = _partition(array, l, r);
                _quickSort(array, l, p - 1);
                _quickSort(array, p + 1, r);
            }
        }
        public void QuickSort()
        {
            _quickSort(array, 0, array.Length-1);
        }
    }
}
