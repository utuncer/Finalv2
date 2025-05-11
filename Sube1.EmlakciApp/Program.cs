using Sube1.EmlakciLib;
using System.Net.WebSockets;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KiralikEv ke = new KiralikEv(500, 600, 3, "Kiralik Ev", 100, 80);
            KiralikEv ke1 = new KiralikEv(800, 900, 2, "Kiralik Ev", 120, 90);
            KiralikEv ke2 = new KiralikEv(10000, 10000, 4, "Kiralik Ev", 200, 100);


            var se = new SatilikEv(400, 3, "Satılık Ev", 110, 60);
            var se1 = new SatilikEv(700, 2, "Satılık Ev", 120, 70);
            var se2 = new SatilikEv(900, 4, "Satılık Ev", 140, 80);

            Ev[] evler = { ke, ke1, ke2, se, se1, se2};

            for (int i = 0; i < evler.Length; i++)
            {
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("\n------------------\n");
            }
        }
    }
}