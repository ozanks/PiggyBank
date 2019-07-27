using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozan_kumbara1.Classes
{
    class MadeniPara : Para
    {
        public MadeniPara(double cap,double kalinlik)
        {
            this.cap = cap;
            this.Kalinlik = kalinlik;
        }


        
        public const decimal besKurus = 0.05m;
        public const decimal onKurus = 0.1m;
        public const decimal yirmiBesKurus = 0.25m;
        public const decimal elliKurus = 0.5m;
        public const decimal birLira = 1.00m;



        public const double Pi = 3.14;
        public double cap { get; set; }
        public double Kalinlik { get; set; }
        public override double HacimHesapla()
        {
            return Math.Pow(this.cap * 2, 2) * MadeniPara.Pi;
        }

        public double BosHacim(double hacim)
        {
            double bosluk;
            Random rnd = new Random();
            return bosluk = hacim * rnd.Next(25,75) * 0.01;
        }
    }
}
