using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            Satisfiyat = satisfiyat;
        }

        public double Satisfiyat { get; set; }

        public override string EvBilgileri()
        {
            return 
                $"Oda Sayısı:{this.Odasayisi}\n" +
                $"Kat no:{this.Katno}\n" +
                $"Alan:{this.Alan}\n" +
                $"Semt:{this.Semt}\n" +
                $"Büyüklük:{this.Buyukluk}\n" +
                $"Satış Fiyat:{this.Satisfiyat}";
        }
    }
}