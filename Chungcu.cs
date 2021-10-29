using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class ChungCu : KhuDat
    {
        #region Liệt kê 
        private int tang;

        public int Tang
        {
            get { return tang; }
            set { tang = value; }
        }

        public ChungCu()
        {

        }
        public ChungCu(int tang)
        {
            this.tang = tang;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập tầng :");
            Tang = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Tầng : {0} ", this.tang);
        }
    }
    #endregion

}
