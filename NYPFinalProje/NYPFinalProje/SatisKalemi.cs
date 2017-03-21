using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
    public class SatisKalemi
    {
        public int Miktar { get; set; }
        public Urun Urun { get; set; } 
        public int GiderHesapla()
        {

            return this.Miktar * this.Urun.urunDetay.BayiFiyat;
        }
        public int KarHesapla()
        {
           return  FiyatHesapla() - GiderHesapla();

        }

        public int FiyatHesapla()
        {
            return this.Miktar * this.Urun.urunDetay.ListeFiyat;
        }

        public string satisKalemiYazdir(Urun u)
        {
            string tmp ="Urun Ad"+ u.urunAd+" Miktari:"+Miktar+"Tutar"+FiyatHesapla().ToString();
            return tmp;
        }

        public SatisKalemi()
        {

        }
        public SatisKalemi(int miktar,Urun urun)
        {
            this.Miktar = miktar;
            this.Urun = urun;

        }
        public void SatisKalemiOlustur(int miktar, Urun urun)
        {
            this.Urun = urun;
            this.Miktar = miktar;

        }
    }
}
