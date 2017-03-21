using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
    public class Dukkan
    {
        public UrunKatalogu urunKatalog { get; set; }
        public HesapDefteri hesapDefteri { get; set; }
        public Dukkan()
        {
            urunKatalog = new UrunKatalogu();
            hesapDefteri = new HesapDefteri();
        }
    }
}
