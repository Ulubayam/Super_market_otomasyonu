using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPFinalProje
{
    public class Terminal
    {
       
        public KasaGörevlisi gorevli{ get; set; }
        public int TerminalNo { get; set; }

        public Terminal()
        {
           
            gorevli = new KasaGörevlisi();
        }
    }
}
