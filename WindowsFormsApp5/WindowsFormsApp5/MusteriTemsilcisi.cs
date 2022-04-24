using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class MusteriTemsilcisi
    {
        public string tur { get; set; }
        public string durum { get; set; }
        public int Temsilciid { get; set; } = 0;
        public int yaptıgıGorusmeSay { get; set; }
        private int cnt { get; set; } = 1;

        public MusteriTemsilcisi()
        {
            this.Temsilciid += 1;
            if (cnt < 3)
                this.durum = "Bireysel"; //4 müşteri temsilcisinden ilk 2'si bireysel.
            else
                this.durum = "Ticari";  //son 2'si ticari.
            cnt += 1;
        }
    }
}
