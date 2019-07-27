using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozan_kumbara1.Classes
{
    class KagitPara : Para
    {
        public KagitPara(double en,double boy)
        {
            this.En = en;
            this.Boy = boy;
        }

        public const decimal besLira = 5.00m;
        public const decimal onLira = 10.00m;
        public const decimal yirmiLira = 20.00m;
        public const decimal elliLira = 50.00m;
        public const decimal yuzLira = 100.00m;
        


        public double En { get; set; }
        public double Boy { get; set; }
        public const double Kalinlik = 0.025;
        public override double HacimHesapla()
        {
            return this.En * this.Boy * KagitPara.Kalinlik;
        }
        public double BosHacim(double hacim)
        {
            double bosluk;
            Random rnd = new Random();
            return bosluk = hacim * rnd.Next(25, 75) * 0.01;
        }
    }
}
