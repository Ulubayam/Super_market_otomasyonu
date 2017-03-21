using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
    public class HesapDefteri
    {
       
        private int Gelir { get; set; }
        private int Gider { get; set; }



        public HesapDefteri()
        {
            this.Gelir = 0;
            this.Gider = 0;
        }
        public int karHesapla()
        {
            return Gelir - Gider;
        }

        public void KayitOlustur(Satis s)
        {
            this.Gelir += s.Gelir;
            this.Gider += s.Gider;
        }
        public int GelirGetir()
        {
            return Gelir;
        }
        public int GiderGetir()
        {
            return Gider;
        }
       
    }
}
