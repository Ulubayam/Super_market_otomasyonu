using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
    public class Urun
    {
        public string urunAd { get; set; }
        public UrunDetay urunDetay { get; set; }
        public Urun()
        {
            urunDetay = new UrunDetay();
        }
    }
}
