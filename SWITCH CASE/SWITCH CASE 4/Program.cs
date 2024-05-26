using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_CASE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string can = "";
            string chi = "";
            string kq =  "";
            int modcan = 0, modchi = 0;
            Console.WriteLine("Hay nhap ho ten cua ban: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh cua ban: ");
            int NS = int.Parse(Console.ReadLine());
            modcan = NS % 10;
            modchi = NS % 12;
            switch (modcan)
            {
                case 0: can = "Canh"; break;
                case 1: can = "Tan"; break;
                case 2: can = "Nham"; break;
                case 3: can = "Quy"; break;
                case 4: can = "Giap"; break;
                case 5: can = "AT"; break;
                case 6: can = "Binh"; break;
                case 7: can = "Dinh"; break;
                case 8: can = "Mau"; break;
                case 9: can = "Ky"; break;
            }
            switch (modchi)
            {
                case 0: chi = "Than"; break;
                case 1: chi = "Dau"; break;
                case 2: chi = "Tuat"; break;
                case 3: chi = "Hoi"; break;
                case 4: chi = "Ty(chuot)"; break;
                case 5: chi = "Suu"; break;
                case 6: chi = "Dan"; break;
                case 7: chi = "Mao"; break;
                case 8: chi = "Thin"; break;
                case 9: chi = "Ty(ran)"; break;
                case 10: chi = "Ngo"; break;
                case 11: chi = "Mui"; break;
            }
            kq = can + chi;
            Console.WriteLine($"{name} \nTuoi: {kq}");
        }
    }
}
