using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_CASE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string loai_tien = "";
            string hinh_thuc = "";
            int ket_qua = 0;
            Console.WriteLine("nhap loai tien: ");
            loai_tien = Console.ReadLine();
            Console.WriteLine("nhap tien: ");
            int tien = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap hinh thuc trao doi: ");
            hinh_thuc = Console.ReadLine();
            if(tien < 0)
            {
                Console.WriteLine("nhap sai tien! ");
            }
            else
            {
                switch (loai_tien)
                {
                    case "usd": 
                        switch (hinh_thuc) 
                        {
                            case "mua": ket_qua = tien * 19000;
                                Console.WriteLine($"So tien Viet Nam phai tra la {ket_qua} khi mua usd: ");
                                break;
                            case "ban": ket_qua = tien * 17500;
                                Console.WriteLine($"So tien Viet Nam co duoc la {ket_qua} khi ban usd: ");
                                break;
                        } 
                        break;
                    case "euro":
                        switch (hinh_thuc)
                        {
                            case "mua":
                                ket_qua = tien * 24500;
                                Console.WriteLine($"So tien Viet Nam phai tra la {ket_qua} khi mua euro: ");
                                break;
                            case "ban":
                                ket_qua = tien * 23500;
                                Console.WriteLine($"So tien Viet Nam co duoc la {ket_qua} khi ban euro: ");
                                break;
                        }
                        break;
                    case "yen":
                        switch (hinh_thuc)
                        {
                            case "mua":
                                ket_qua = tien * 1300;
                                Console.WriteLine($"So tien Viet Nam phai tra la {ket_qua} khi mua yen: ");
                                break;
                            case "ban":
                                ket_qua = tien * 1205;
                                Console.WriteLine($"So tien Viet Nam co duoc la {ket_qua} khi ban yen: ");
                                break;
                        }
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
