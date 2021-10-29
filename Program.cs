using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
            Console.ReadKey();
        }
        public static void Menu()
        {
            int choose = 0;
            List<KhuDat> KhuDats = new List<KhuDat>();

            do
            {
                Console.WriteLine("# MENU # ");
                Console.WriteLine("# 1.  Nhap khu dat.");
                Console.WriteLine("# 2.  Nhap nha pho.");
                Console.WriteLine("# 3.  Nhap chung cu");
                Console.WriteLine("# 4.  Xuat ds .");
                Console.WriteLine("# 5.  Xuat tong tien ds.");
                Console.WriteLine("# 0.  Exit.");

                bool checkchoose = false;
                do
                {
                    checkchoose = int.TryParse(Console.ReadLine(), out choose);
                    if (!checkchoose || choose < 0 || choose > 5)
                    {
                        Console.WriteLine("# chon Menu tu 0-5");
                    }
                } while (!checkchoose || choose < 0 || choose > 5);
                switch (choose)
                {
                    case 0:
                        Console.WriteLine("-------Exit-------");
                        break;
                    case 1:
                        Console.WriteLine("Khu dat");
                        KhuDat khuDat = new KhuDat();
                        khuDat.Input();
                        KhuDats.Add(khuDat);
                        break;
                    case 2:
                        Console.WriteLine("Nha pho");
                        NhaPho nhaPho = new NhaPho();
                        nhaPho.Input();
                        KhuDats.Add(nhaPho);
                        break;
                    case 3:
                        Console.WriteLine("Chung cu");
                        ChungCu chungCu = new ChungCu();
                        chungCu.Input();
                        KhuDats.Add(chungCu);
                        break;
                    case 4:
                        foreach (var KhuDat in KhuDats)
                        {
                            KhuDat.Output();

                        }
                        break;
                    case 5:
                        long sumGiaKhuDat = 0;
                        long sumGiaNhaPho = 0;
                        long sumGiaChungCu = 0;
                        foreach (var KhuDat in KhuDats)
                        {
                            switch (KhuDat.GetType().Name)
                            {
                                case "KhuDat":
                                    sumGiaKhuDat += KhuDat.Giaban;
                                    break;
                                case "NhaPho":
                                    sumGiaNhaPho += KhuDat.Giaban;
                                    break;
                                case "NhanVienPTN":
                                    sumGiaChungCu += KhuDat.Giaban;
                                    break;
                            }
                        }
                        Console.WriteLine("\tTổng giá Khu Đất :\t{0}", sumGiaKhuDat);
                        Console.WriteLine("\tTổng giá Nhà Phố:\t{0}", sumGiaNhaPho);
                        Console.WriteLine("\tTổng giá Chung Cư:\t{0}", sumGiaChungCu);
                        break;
                }

            } while (choose != 0);


        }


    }
}
