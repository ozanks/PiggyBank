using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozan_kumbara1.Classes
{
    class Kumbara : ISallanabilirlik
    {
        
        public static double KumbaraHacmi = 500;

        public double Shake(double fazladanKaplananHacim)
        {
            Random rnd = new Random();
            return fazladanKaplananHacim = fazladanKaplananHacim * rnd.Next(25, 75) * 0.001;
        }
    }
}
