using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class KhuDat
    {
        private string diadiem;

        public string Diadiem
        {
            get { return diadiem; }
            set { diadiem = value; }
        }

        private int giaban;

        public int Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        private float dientich;

        public float Dientich
        {
            get { return dientich; }
            set { dientich = value; }
        }


        public KhuDat()
        {

        }

        public KhuDat(string diadiem, int giaban, float dientich)
        {
            this.diadiem = diadiem;
            this.giaban = giaban;
            this.dientich = dientich;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhập địa điểm :");
            Diadiem = Console.ReadLine();
            Console.WriteLine("Nhập giá bán :");
            Giaban = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điện tích :");
            Dientich = float.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("Địa điểm là : {0} Giá bán : {1} Diện tích : {2} ", this.diadiem, this.giaban, this.dientich);
        }
    }
}
