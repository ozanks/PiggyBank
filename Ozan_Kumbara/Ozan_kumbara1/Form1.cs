using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozan_kumbara1.Classes;

namespace Ozan_kumbara1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kumbara k = new Kumbara();
        decimal kumbaradakiToplam;
        double ToplamParaHacmi;
        double fazlaHacim;
        int kirilmaSayisi = 0;
        List<string> KumbaradakiParalar = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

            cmbParaSec.Text = "PARA SEÇ";
        }



        private void btnKumbarayaAt_Click(object sender, EventArgs e)
        {
            if (kirildiMi == false)
            {
                if (ToplamParaHacmi < Kumbara.KumbaraHacmi)
                {
                    string secilen = cmbParaSec.Text;
                    if (secilen == "5 kr" || secilen == "10 kr" || secilen == "25 kr" || secilen == "50 kr" || secilen == "1 TL")
                    {
                        #region Madeni Seçildiğinde
                        switch (secilen)
                        {
                            case "5 kr":
                                kumbaradakiToplam += MadeniPara.besKurus;
                                MadeniPara madeni05 = new MadeniPara(1.7, 0.165);
                                madeni05.Isim = "5 kr";
                                madeni05.Miktar = MadeniPara.besKurus;
                                madeni05.Hacim = madeni05.HacimHesapla() + madeni05.BosHacim(madeni05.Hacim);
                                fazlaHacim += madeni05.BosHacim(madeni05.Hacim);
                                ToplamParaHacmi += madeni05.Hacim;
                                KumbaradakiParalar.Add(madeni05.Isim);
                                break;
                            case "10 kr":
                                kumbaradakiToplam += MadeniPara.onKurus;
                                MadeniPara madeni10 = new MadeniPara(1.9, 0.17);
                                madeni10.Isim = "10 kr";
                                madeni10.Miktar = MadeniPara.onKurus;
                                madeni10.Hacim = madeni10.HacimHesapla() + madeni10.BosHacim(madeni10.Hacim);
                                ToplamParaHacmi += madeni10.Hacim;
                                fazlaHacim += madeni10.BosHacim(madeni10.Hacim);
                                KumbaradakiParalar.Add(madeni10.Isim);
                                break;
                            case "25 kr":
                                kumbaradakiToplam += MadeniPara.yirmiBesKurus;
                                MadeniPara madeni25 = new MadeniPara(2.1, 0.19);
                                madeni25.Isim = "25 kr";
                                madeni25.Miktar = MadeniPara.yirmiBesKurus;
                                madeni25.Hacim = madeni25.HacimHesapla() + madeni25.BosHacim(madeni25.Hacim);
                                ToplamParaHacmi += madeni25.Hacim;
                                fazlaHacim += madeni25.BosHacim(madeni25.Hacim);
                                KumbaradakiParalar.Add(madeni25.Isim);
                                break;
                            case "50 kr":
                                kumbaradakiToplam += MadeniPara.elliKurus;
                                MadeniPara madeni50 = new MadeniPara(2.3, 0.195);
                                madeni50.Isim = "50 kr";
                                madeni50.Miktar = MadeniPara.elliKurus;
                                madeni50.Hacim = madeni50.HacimHesapla() + madeni50.BosHacim(madeni50.Hacim);
                                ToplamParaHacmi += madeni50.Hacim;
                                fazlaHacim += madeni50.BosHacim(madeni50.Hacim);
                                KumbaradakiParalar.Add(madeni50.Isim);
                                break;
                            case "1 TL":
                                kumbaradakiToplam += MadeniPara.birLira;

                                MadeniPara madeni1 = new MadeniPara(2.6, 0.195);
                                madeni1.Isim = "1 TL";
                                madeni1.Miktar = MadeniPara.birLira;
                                madeni1.Hacim = madeni1.HacimHesapla() + madeni1.BosHacim(madeni1.Hacim);
                                ToplamParaHacmi += madeni1.Hacim;
                                fazlaHacim += madeni1.BosHacim(madeni1.Hacim);
                                KumbaradakiParalar.Add(madeni1.Isim);
                                break;
                        }
                        #endregion
                    }

                    else if (cbKatla.Checked == true)
                    {
                        #region Kağıt Para Seçildiğinde
                        switch (secilen)
                        {
                            case "5 TL":
                                KagitPara kagit05 = new KagitPara(6.4, 13);
                                kagit05.Isim = "5 TL";
                                kagit05.Miktar = KagitPara.besLira;
                                kumbaradakiToplam += KagitPara.besLira;
                                kagit05.Hacim = kagit05.HacimHesapla() + kagit05.BosHacim(kagit05.Hacim);
                                ToplamParaHacmi += kagit05.Hacim;
                                fazlaHacim += kagit05.BosHacim(kagit05.Hacim);
                                KumbaradakiParalar.Add(kagit05.Isim);
                                break;
                            case "10 TL":
                                KagitPara kagit10 = new KagitPara(6.4, 13);
                                kagit10.Isim = "10 TL";
                                kagit10.Miktar = KagitPara.onLira;
                                kumbaradakiToplam += KagitPara.onLira;
                                kagit10.Hacim = kagit10.HacimHesapla() + kagit10.BosHacim(kagit10.Hacim);
                                ToplamParaHacmi += kagit10.Hacim;
                                fazlaHacim += kagit10.BosHacim(kagit10.Hacim);
                                KumbaradakiParalar.Add(kagit10.Isim);
                                break;
                            case "20 TL":
                                KagitPara kagit20 = new KagitPara(6.8, 14.2);
                                kagit20.Isim = "20 TL";
                                kagit20.Miktar = KagitPara.yirmiLira;
                                kagit20.Hacim = kagit20.HacimHesapla() + kagit20.BosHacim(kagit20.Hacim);
                                kumbaradakiToplam += KagitPara.yirmiLira;
                                ToplamParaHacmi += kagit20.Hacim;
                                fazlaHacim += kagit20.BosHacim(kagit20.Hacim);
                                KumbaradakiParalar.Add(kagit20.Isim);
                                break;
                            case "50 TL":
                                KagitPara kagit50 = new KagitPara(6.4, 14.8);
                                kagit50.Isim = "50 TL";
                                kagit50.Miktar = KagitPara.elliLira;
                                kagit50.Hacim = kagit50.HacimHesapla() + kagit50.BosHacim(kagit50.Hacim);
                                kumbaradakiToplam += KagitPara.elliLira;
                                ToplamParaHacmi += kagit50.Hacim;
                                fazlaHacim += kagit50.BosHacim(kagit50.Hacim);
                                KumbaradakiParalar.Add(kagit50.Isim);
                                break;
                            case "100 TL":
                                KagitPara kagit100 = new KagitPara(7.2, 16);
                                kagit100.Isim = "100 TL";
                                kagit100.Miktar = KagitPara.yuzLira;
                                kagit100.Hacim = kagit100.HacimHesapla() + kagit100.BosHacim(kagit100.Hacim);
                                kumbaradakiToplam += KagitPara.yuzLira;
                                ToplamParaHacmi += kagit100.Hacim;
                                fazlaHacim += kagit100.BosHacim(kagit100.Hacim);
                                KumbaradakiParalar.Add(kagit100.Isim);
                                break;

                        }
                        #endregion

                    }
                    else
                    {
                        MessageBox.Show(KumbaraExceptions.KatlamadanKumbarayaAtma());
                    }
                }
                else
                {
                    MessageBox.Show(KumbaraExceptions.KumbaraDolu());
                }
            }
            else
            {
                MessageBox.Show(KumbaraExceptions.YapıştırmadanParaEkleme());
            }
            // LabelYazdır();


        }
        public void LabelYazdır()
        {
            label1.Text = "";
            label1.Text = "Toplam Para :" + kumbaradakiToplam.ToString();
        }
        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (ToplamParaHacmi > fazlaHacim)
            {
                ToplamParaHacmi = ToplamParaHacmi - k.Shake(fazlaHacim);
                //LabelYazdır();
            }
            else
            {
                MessageBox.Show(KumbaraExceptions.YavasSalla());
            }
        }
        public void KumbarayiKir()
        {
            LabelYazdır();
            kirilmaSayisi++;
            kirildiMi = true;
            foreach (string item in KumbaradakiParalar)
            {
                listBox1.Items.Add(item);
            }
            pictureBox1.Image = Image.FromFile(Application.StartupPath+@"/../../Images/BrokenPiggy.png");

        }
        bool kirildiMi;
        public void Yapistir()
        {
            label1.Text = "";
            listBox1.Items.Clear();
            ToplamParaHacmi = 0;
            kumbaradakiToplam = 0;
            Kumbara.KumbaraHacmi = 500;
            kirildiMi = false;
            KumbaradakiParalar.Clear();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/../../Images/piggy.png");
        }

        private void btnKir_Click(object sender, EventArgs e)
        {
            if (kirildiMi == false)
            {
                KumbarayiKir();

            }

            else
            {
                MessageBox.Show(KumbaraExceptions.YapıştırmadanKiramazsin());
            }

        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            if (kirilmaSayisi < 2)
            {
                Yapistir();
            }
            else
            {
                MessageBox.Show(KumbaraExceptions.BirdenFazlaKirma());
            }
        }
    }
}
