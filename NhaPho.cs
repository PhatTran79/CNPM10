using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class NhaPho : KhuDat
    {
        private int namxaydung;

        public int Namxaydung
        {
            get { return namxaydung; }
            set { namxaydung = value; }
        }

        private int sotang;

        public int Sotang
        {
            get { return sotang; }
            set { sotang = value; }
        }

        public NhaPho()
        {

        }
        public NhaPho(int namxaydung, int sotang)
        {
            this.namxaydung = namxaydung;
            this.sotang = sotang;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập năm xây dụng :");
            Namxaydung = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tầng :");
            Sotang = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Năm xây dựng : {0} Số tầng : {1}  ", this.namxaydung, this.sotang);
        }
    }
}
