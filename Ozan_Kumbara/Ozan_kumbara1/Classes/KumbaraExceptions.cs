using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozan_kumbara1.Classes
{
    class KumbaraExceptions
    {
        public static string KatlamadanKumbarayaAtma()
        {
            return "Kağıt Paraları katlamadan kumbaraya atamazsınız.";
        }
        public static string KumbaraDolu()
        {
            return "Kumbara Doldu.";
        }
        public static string YapıştırmadanParaEkleme()
        {

            return "Kumbarayı yapıştırmadan para ekleyemezsiniz.";
        }

        public static string YapıştırmadanKiramazsin()
        {

            return "Yapıştırmadan tekrar kıramazsınız!";
        }
        public static string BirdenFazlaKirma()
        {

            return"Bir defadan fazla yapıştıramazsınız.";
        }
        public static string YavasSalla()
        {
            return " Yavaş salla. Daha fazla yer açamazsın.";
        }

    }
}
