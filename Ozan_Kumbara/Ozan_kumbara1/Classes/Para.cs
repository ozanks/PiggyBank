using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozan_kumbara1.Classes
{
    public abstract class Para
    {
        public string Isim { get; set; }
        public decimal Miktar { get; set; }
        public double Hacim { get; set; }


        public abstract double HacimHesapla();
        public override string ToString()
        {
            return this.Miktar.ToString();
        }
    }
}
