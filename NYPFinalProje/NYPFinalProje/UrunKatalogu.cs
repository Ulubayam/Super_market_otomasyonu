using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
   public class UrunKatalogu
    {
        public List<Urun> urunler { get; set; }
        public UrunKatalogu()
        {
            urunler = new List<Urun>();
        }
        public void urunEkle(Urun u)
        {
            urunler.Add(u);
        }
        public void UrunCikar(Urun u)
        {
            urunler.Remove(u);
        }
        public List<Urun> urunListesi()
        {
            
            return urunler;
        }
    }
}
