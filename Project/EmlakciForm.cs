using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmlakciKayitSistemiGUI
{
    public partial class EmlakciForm : Form
    {
        private string dosyaYolu = "emlakci_kayitlari.txt";
        private List<Kayit> kayitlar;

        public EmlakciForm()
        {
            InitializeComponent();
            kayitlar = new List<Kayit>();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    while (!reader.EndOfStream)
                    {
                        string satir = reader.ReadLine();
                        string[] veriler = satir.Split(',');

                        string ad = veriler[0];
                        string soyad = veriler[1];
                        string telefon = veriler[2];
                        string adres = veriler[3];
                        string satisFiyati = veriler[4];

                        Kayit kayit = new Kayit(ad, soyad, telefon, adres, satisFiyati);
                        kayitlar.Add(kayit);
                    }
                }

                // ListView'i güncelle
                ListViewGuncelle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            string satisFiyati = txtSatisFiyati.Text;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(adres) || string.IsNullOrWhiteSpace(satisFiyati))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Kayıt verilerini bir satır olarak oluştur
            string kayit = $"{ad},{soyad},{telefon},{adres},{satisFiyati}";

            // Kaydı dosyaya yaz
            using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
            {
                writer.WriteLine(kayit);
            }

            // Yeni kaydı listeye ekle
            Kayit yeniKayit = new Kayit(ad, soyad, telefon, adres, satisFiyati);
            kayitlar.Add(yeniKayit);

            // ListView'i güncelle
            ListViewGuncelle();

            // Kayıt tamamlandı mesajı göster
            MessageBox.Show("Kayıt başarıyla eklendi.");

            // Alanları temizle
            Temizle();
        }

        private void ListViewGuncelle()
        {
            listViewKayitlar.Items.Clear();

            foreach (Kayit kayit in kayitlar)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { kayit.Ad, kayit.Soyad, kayit.Telefon, kayit.Adres, kayit.SatisFiyati });
                listViewKayitlar.Items.Add(listViewItem);
            }
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            txtSatisFiyati.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower();

            if (string.IsNullOrWhiteSpace(aranan))
            {
                MessageBox.Show("Lütfen bir arama kelimesi girin.");
                return;
            }

            listViewKayitlar.Items.Clear();

            foreach (Kayit kayit in kayitlar)
            {
                if (kayit.Ad.ToLower().Contains(aranan) || kayit.Soyad.ToLower().Contains(aranan) || kayit.Telefon.ToLower().Contains(aranan) || kayit.Adres.ToLower().Contains(aranan) || kayit.SatisFiyati.ToLower().Contains(aranan))
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] { kayit.Ad, kayit.Soyad, kayit.Telefon, kayit.Adres, kayit.SatisFiyati });
                    listViewKayitlar.Items.Add(listViewItem);
                }
            }

            if (listViewKayitlar.Items.Count == 0)
            {
                MessageBox.Show("Arama sonucunda hiçbir kayıt bulunamadı.");
            }
        }
    }

    public class Kayit
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string SatisFiyati { get; set; }

        public Kayit(string ad, string soyad, string telefon, string adres, string satisFiyati)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
            Adres = adres;
            SatisFiyati = satisFiyati;
        }
    }
}
