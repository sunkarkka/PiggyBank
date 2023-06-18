using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiggyBank.Exception_Library;
using PiggyBank.Concrete;

namespace PiggyBank
{
    public partial class KumbaraForm : Form
    {
        Kumbara kumbara = new Kumbara(75000);

        private readonly List<KagitPara> KagitParalar = new List<KagitPara>();
        private readonly List<BozukPara> BozukParalar = new List<BozukPara>();
        private readonly BindingList<Para> atilanKagitParalar = new BindingList<Para>();
        private readonly BindingList<Para> atilanBozukParalar = new BindingList<Para>();

        Para secilen;
        string atilacak;
        bool katlandiMi = false;
        int kirilmaSayisi = 0;
        double birikenMiktar = 0;
        double toplamHacim = 0;
        double fazlaHacim = 0;

        public KumbaraForm()
        {
            InitializeComponent();
            ParalariOlusturEkle();
            pnlDolu.Height = 0;
        }
        private void ParalariOlusturEkle()
        {
            BozukParalar.Add(new BozukPara() { Type = "1 Kuruş", Value = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Type = "5 Kuruş", Value = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Type = "10 Kuruş", Value = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Type = "25 Kuruş", Value = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Type = "50 Kuruş", Value = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Type = "1 Lira", Value = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Type = "5 Lira", Value = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Type = "10 Lira", Value = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Type = "20 Lira", Value = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Type = "50 Lira", Value = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Type = "100 Lira", Value = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Type = "200 Lira", Value = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cmbKagitPara.Items.Add("Choose!");
            foreach (var item in KagitParalar)
            {
                cmbKagitPara.Items.Add(item.Type);
            }
            cmbKagitPara.SelectedIndex = 0;
            cmbBozukPara.Items.Add("Choose!");
            foreach (var item in BozukParalar)
            {
                cmbBozukPara.Items.Add(item.Type);
            }
            cmbBozukPara.SelectedIndex = 0;
        }
        private void cmbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKagitPara.SelectedIndex > 0)
            {
                cmbBozukPara.Enabled = false;
                btnKatla.Visible = true;
                atilacak = cmbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacak == item.Type)
                    {
                        secilen = (KagitPara)item;
                    }
                }
            }
        }
        private void cmbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBozukPara.SelectedIndex > 0)
            {
                cmbKagitPara.Enabled = false;
                atilacak = cmbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacak == item.Type)
                    {
                        secilen = (BozukPara)item;
                    }
                }
            }
        }
        private void btnParaAt_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen == null)
                {
                    throw new ParaSecilmediException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (secilen is BozukPara)
            {
                BozukPara bozukpara = (BozukPara)secilen;
                try
                {
                    if (toplamHacim + bozukpara.Hacim() + bozukpara.FazladanHacimHesapla(secilen.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new DoluKumbaraException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                atilanBozukParalar.Add(bozukpara);
                birikenMiktar += bozukpara.Value;
                toplamHacim += bozukpara.Hacim() + bozukpara.FazladanHacimHesapla(bozukpara.Hacim());
                fazlaHacim += bozukpara.FazladanHacimHesapla(bozukpara.Hacim());

                kumbara.ParaEkle(bozukpara.Hacim() + bozukpara.FazladanHacimHesapla(bozukpara.Hacim()));
              
                SeviyeGuncelle();
                HacimleriYazdir();
            }
            else if (secilen is KagitPara)
            {
                KagitPara kagitpara = (KagitPara)secilen;
                try
                {
                    if (toplamHacim + kagitpara.Hacim() + kagitpara.FazladanHacimHesapla(secilen.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new DoluKumbaraException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                try
                {
                    if (katlandiMi == false)
                    {
                        throw new ParaKatlanmadiException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                atilanKagitParalar.Add(kagitpara);
                birikenMiktar += kagitpara.Value;
                toplamHacim += kagitpara.Hacim() + kagitpara.FazladanHacimHesapla(kagitpara.Hacim());
                fazlaHacim += kagitpara.FazladanHacimHesapla(kagitpara.Hacim());

                kumbara.ParaEkle(kagitpara.Hacim() + kagitpara.FazladanHacimHesapla(kagitpara.Hacim()));
                pnlDolu.Height = (int)(kumbara.DolulukOrani * pnlTotal.Height);
               
                HacimleriYazdir();
            }
            btnSalla.Enabled = true;
            VerileriSifirla();
        }
        private void VerileriSifirla()
        {
            cmbBozukPara.SelectedIndex = 0;
            cmbKagitPara.SelectedIndex = 0;
            katlandiMi = false;
            btnKatla.Text = "Fold It!";
            btnKatla.Enabled = true;
            btnKatla.Visible = false;
            secilen = null;
            cmbBozukPara.Enabled = true;
            cmbKagitPara.Enabled = true;
        }
        private void btnKatla_Click(object sender, EventArgs e)
        {
            KagitPara katlanacak = (KagitPara)secilen;
            if (katlanacak != null)
            {
                katlandiMi = true;
                katlanacak.Katla(katlanacak.Hacim());
                btnKatla.Text = "Folded!";
                btnKatla.Enabled = false;
            }
           
        }
        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (toplamHacim > fazlaHacim)
            {
                toplamHacim = toplamHacim - kumbara.Salla(fazlaHacim);
                kumbara.ParaEkle(-kumbara.Salla(fazlaHacim));
            }
          
            SeviyeGuncelle();
            fazlaHacim = 0;
            btnSalla.Enabled = false;
            HacimleriYazdir();
            VerileriSifirla();
        }
        private void btnKir_Click(object sender, EventArgs e)
        {
            if (kirilmaSayisi == 0)
            {
                KırıkKumbaraForm paralarForm = new KırıkKumbaraForm(atilanKagitParalar, atilanBozukParalar, birikenMiktar);
                try
                {
                    if (birikenMiktar > 0)
                    {
   
                        paralarForm.ShowDialog();
                    }
                    else
                    {
                        throw new BosKumbaraException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnKir.Text = "Fix It!";
                btnParaAt.Enabled = false;
                btnKatla.Enabled = false;
                btnSalla.Enabled = false;
                atilanKagitParalar.Clear();
                atilanBozukParalar.Clear();
                kirilmaSayisi++;
                cmbBozukPara.Enabled = false;
                cmbKagitPara.Enabled = false;
                KumbaraSifirla();
                SeviyeGuncelle();
            }
            else if (kirilmaSayisi == 1)
            {
                btnKir.Text = "Braek Now!";
                cmbBozukPara.Enabled = true;
                cmbKagitPara.Enabled = true;
                btnParaAt.Enabled = true;
                btnKatla.Enabled = true;
                btnSalla.Enabled = true;
                kirilmaSayisi++;
                KumbaraSifirla();
                SeviyeGuncelle();
            }
            else if (kirilmaSayisi > 1)
            {
                KırıkKumbaraForm paralarForm = new KırıkKumbaraForm(atilanKagitParalar, atilanBozukParalar, birikenMiktar);
                try
                {
                    if (birikenMiktar > 0)
                    {
                        
                        paralarForm.ShowDialog();
                    }
                    else
                    {
                        throw new BosKumbaraException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnKir.Text = "Unbreakable!";
                btnParaAt.Enabled = false;
                btnKir.Enabled = false;
                btnKatla.Enabled = false;
                btnSalla.Enabled = false;
                KumbaraSifirla();
                SeviyeGuncelle();
                try
                {
                    throw new KumbaraKullanilamazException();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }
    
        private void KumbaraSifirla()
        {
            birikenMiktar = 0;
            kumbara.ParaMiktari = 0;
            toplamHacim = 0;
            fazlaHacim = 0;
            lblParaHacmi.Text = "Volume Of Coins: 0";
            lblFazladan.Text = "Extra Volume Occupied By Coins : 0";
            pnlDolu.Height = 0;
        }
        private void SeviyeGuncelle()
        {
            pnlDolu.Height = (int)(kumbara.DolulukOrani * pnlTotal.Height);
        }
        public void HacimleriYazdir()
        {
            lblParaHacmi.Text = "Volume of Coins: " + toplamHacim.ToString();
            lblFazladan.Text = "Extra Volume Occupied By Coins: " + fazlaHacim.ToString();
        }

        private void pnlTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblParaHacmi_Click(object sender, EventArgs e)
        {

        }

        private void lblBozukPara_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblFazladan_Click(object sender, EventArgs e)
        {

        }
    }
}
