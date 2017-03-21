using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPFinalProje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            KatalogDoldur();
          
            kg.ad = "Gizem";
            kg.soyad = "Gokhan";
            kg.TCKN = 123;
            kg.calisanNo = 11;
            ComboBoxDoldur();

        }
        KasaGörevlisi kg = new KasaGörevlisi();
        Dukkan dk = new Dukkan();
        HesapDefteri hd = new HesapDefteri();
        Random r = new Random();
        #region Functions
        public void KatalogDoldur()
        {
           
            for (int i = 0; i < 5; i++)
            {
               
                Urun u = new Urun();
                u.urunAd = "Urun" + i;
                
                u.urunDetay.BayiFiyat = r.Next(1, 10);
                u.urunDetay.ListeFiyat = r.Next(10,20);
                

                dk.urunKatalog.urunEkle(u);
            }
           
        }
        public void ComboBoxDoldur()
        {
            foreach (var item in dk.urunKatalog.urunler)
            {
                ComboboxItem it = new ComboboxItem();
                it.Text = item.urunAd;
                it.Value = item;
                cmbUrunler.Items.Add(it);
               


            }
            
        }
        Musteri m = new Musteri();
         List<Musteri> musteri = new List<Musteri>();
        public void MusteriDoldur()
        {
           

            for (int i = 0; i < 5; i++)
            {

                m.ad = "Musteri" + i.ToString();
                musteri.Add(m);

                
            }


        }
       
        
       
       
       
        #endregion
       

        private void btnSatiAl_Click(object sender, EventArgs e)
        {
            
        }
        Satis s = new Satis();
        List<Urun> Urunler = new List<Urun>();
        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            
            Urun u = ((ComboboxItem)(cmbUrunler.SelectedItem)).Value;
            SatisKalemi sk = new SatisKalemi(Convert.ToInt32( txtUrunAdetBilgi.Text),u);

            s.SatisKalemiEkle(sk);
            Urunler.Add(u);
            ListBoxDoldur(Convert.ToInt32(txtUrunAdetBilgi.Text),u);
            

            
        }
        public void ListBoxDoldur(int adet,Urun item)
        {
           
            
                listUrun.Items.Add(item.urunAd+" Adet="+" "+adet + "Tutar ="+(item.urunDetay.ListeFiyat*adet));

            
        }

        private void btnKarGoruntule_Click(object sender, EventArgs e)
        {
            richKar.Text = "Gelir = "+hd.GelirGetir().ToString()+"\nGider ="+hd.GiderGetir().ToString()+"\nKar = "+hd.karHesapla();
        }
        
        private void btnSatınAl_Click(object sender, EventArgs e)
        { 
            s.OdemeHesapla(s.satisKalemi);
           
            Musteri musteri = new Musteri();
            musteri.musteriNo = 12;
            s.MusteriEkle(musteri);

            hd.KayitOlustur(s);
            richHesapOzeti.Text ="Kasa Görevlisi = "+kg.ad+"\nCalisan Numarası = " + kg.calisanNo +"\nToplam Tutar = "+Convert.ToString(s.OdemeMiktar.OdemeMiktari)+"\nMusteri Numarası = "+s.Musteri.musteriNo;
            yeniSatis();
            
           

        }

        public void yeniSatis()
        {
            s = new Satis()
                ;

            txtUrunAdetBilgi.Text = "";
            listUrun.Items.Clear();
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public Urun Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}
