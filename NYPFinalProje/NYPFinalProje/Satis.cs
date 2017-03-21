using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
    public class Satis
    {
        public DateTime satisTarihi { get; set; }
        public Musteri Musteri { get; set; }
        public int Gelir { get; set; }
        public int Gider { get; set; }
        public List<SatisKalemi> satisKalemi = new List<SatisKalemi>();
       
        public Odeme OdemeMiktar { get; set; }
        public Satis()
        {
            satisKalemi = new List<SatisKalemi>();
            OdemeMiktar = new Odeme();
           
           
           
        }
        public void MusteriEkle(Musteri m )
        {
            this.Musteri = m;
        }

        public void OdemeHesapla(List<SatisKalemi> sk)
        {
            int toplam = 0,gelir=0,gider=0;
            
            foreach (var satis in sk)
            {

                toplam += satis.FiyatHesapla();
                gider += satis.GiderHesapla();
                gelir += satis.KarHesapla();
               
            }
            OdemeMiktar.OdemeMiktari = toplam;
            this.Gelir = gelir;
            this.Gider = gider;
        }

        

        public void SatisKalemiEkle(SatisKalemi s)
        {
            satisKalemi.Add(s);
        }

    }
}
