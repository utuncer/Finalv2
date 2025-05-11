using System;

namespace Sube1.EmlakciLib
{
    public class Ev
    {
        public static int Sayac { get; private set; }

        public Ev()
        {
            Sayac++;
        }
        public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay")
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            Sayac++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Kızılay";
            this.Alan = alan;
            Sayac++;
        }


        private string semt;
        public string Buyukluk { get; private set; }
        public int Katno { get; set; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        private int odasayisi;      
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }
        private double alan;
        public double Alan
        {

            get { return alan; }
            set
            {
                if (value < 50)
                {
                    throw new Exception("Min alan değeri 50 olmalıdır");
                }
                alan = value;
                if (this.alan > 50 && this.alan < 75)
                {
                    this.Buyukluk = "Küçük Ev";
                }
                else if (this.alan > 75 && this.alan < 120)
                {
                    this.Buyukluk = "Orta büyüklükte ev";
                }
                else
                {
                    this.Buyukluk = "Büyük ev";
                }
            }
        }

        public virtual string EvBilgileri()
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat no:{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nBüyüklük:{this.Buyukluk}";
        }
    }
}