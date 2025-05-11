using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(double kira, double depozito, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;
        }

        public double Kira { get; set; }
        public double Depozito { get; set; }

        public override string EvBilgileri()
        {
            return
                $"Oda Sayısı:{this.Odasayisi}\n" +
                $"Kat no:{this.Katno}\n" +
                $"Alan:{this.Alan}\n" +
                $"Semt:{this.Semt}\n" +
                $"Büyüklük:{this.Buyukluk}\n" +
                $"Kira:{this.Kira}\n" +
                $"Depozito:{this.Depozito}";
        }
    }
}