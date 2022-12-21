namespace TcddBiletOtomasyon
{
    public partial class OdemeEkrani : Form
    {

        MusteriBilgileri musteriBilgileri = new MusteriBilgileri();
        BiletHazirlamaEkrani biletHazirlamaEkrani = new BiletHazirlamaEkrani();
        public OdemeEkrani()
        {
            InitializeComponent();
        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            musteriBilgileri = Musteri.getir.listMusteriBilgileri[MusteriBilgileri.getir.no];

            //Ödeme ekranı ilk yüklendiğinde sayfadaki bilgileri dolduruyoruz
            labelBakiye.Text = musteriBilgileri.bakiye.ToString();
            musteriBilgileri.toplamTutar = MusteriBilgileri.getir.ToplamHesap();
            labelToplamTutar.Text = MusteriBilgileri.getir.ToplamHesap().ToString();
            labelPuanBakiye.Text = musteriBilgileri.bonusPuan.ToString();
            musteriBilgileri.formlarArasiToplamTutar = MusteriBilgileri.getir.ToplamHesap();
            MusteriBilgileri.getir.formlarArasiToplamTutar = MusteriBilgileri.getir.ToplamHesap();
        }

        //btnPuanKullan butonuna tıklanıldığında çalışacak metod
        private void btnPuanKullan_Click(object sender, EventArgs e)
        {
            decimal girilenBonusPuan = Convert.ToDecimal(txtBonusPuan.Text);
            decimal odenecekToplamTutar = Convert.ToDecimal(labelToplamTutar.Text);

            MessageBox.Show("Toplam Tutarınız:" + musteriBilgileri.toplamTutar + " TL" + "\nBonus Puanınız:" + musteriBilgileri.bonusPuan + " TL");
            
            //girilen bonus puan için kontrol
            if (0 < girilenBonusPuan
                && girilenBonusPuan <= musteriBilgileri.toplamTutar
                && girilenBonusPuan <= musteriBilgileri.bonusPuan
                && String.IsNullOrEmpty(txtBonusPuan.Text) == false
            )
            {
                labelToplamTutar.Text = (odenecekToplamTutar - girilenBonusPuan).ToString();
                musteriBilgileri.toplamTutar = (musteriBilgileri.toplamTutar - girilenBonusPuan);
                musteriBilgileri.bonusPuan = musteriBilgileri.bonusPuan - girilenBonusPuan;

                //Kullanılan bonus puan için bilgi mesajı veriyoruz
                MessageBox.Show("( " + txtBonusPuan.Text + " )TL Bonus puan kullanıldı !\nHesabınızda kalan Bonus Puan : " + musteriBilgileri.bonusPuan.ToString() + " TL");
                
                labelPuanBakiye.Text = musteriBilgileri.bonusPuan.ToString();
                txtBonusPuan.Text = null;

                //Bakiyemizi ve bonus puanlarımızı kullanarak ödemeyi tamamladığımızda
                //bilet hazırlama ekranına geçiyoruz
                if (odenecekToplamTutar == 0)
                {
                    Hide();
                    biletHazirlamaEkrani.Show();
                }
            }
            else if (String.IsNullOrEmpty(txtBonusPuan.Text))
            {
                //Hatalı bonus puan girildiğinde hata
                MessageBox.Show("HATA: Kullanmak istediğiniz bonus puan miktarını girmediniz..");
            }
            else
            {
                //Toplam tutardan fazla bonus ödemesi hatası
                MessageBox.Show("HATA: Toplam tutardan fazla ödeme yapamazsınız..");
            }
        }

        //bonus puan alanına sadece sayı girişi yapılabilmesi için sınırlıyoruz
        private void txtBonusPuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        //btnOde butonuna tıklanıldığında çalışacak metod
        private void btnOde_Click(object sender, EventArgs e)
        {
            //Bakiyemiz yeterliyse ödeme işlemi yapıp bilet hazırlama ekranına geçiyoruz
            //yeterli değilse hata mesajı veriyoruz
            if (musteriBilgileri.bakiye >= musteriBilgileri.toplamTutar)
            {
                musteriBilgileri.bakiye = (musteriBilgileri.bakiye - musteriBilgileri.toplamTutar);
                MessageBox.Show("( " + musteriBilgileri.toplamTutar.ToString() + " )TL bakiyenizden düşüldü..\n Kalan bakiyeniz: " + (musteriBilgileri.bakiye).ToString() + " TL" + "\nBiletinizi almak için 'Tamam'a basınız..");
                labelBakiye.Text = musteriBilgileri.bakiye.ToString();
                Hide();
                biletHazirlamaEkrani.Show();
            }
            else
            {
                MessageBox.Show("Odeme yapamadınz. Yetersiz bakiye..");
            }
        }

        //Puan kullan (Hayır) radio butonu seçildiğinde; 
        //puan kullanım alanını gizliyoruz, logoyu gösteriyoruz
        private void rbPuanKullanHayir_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxpuantablosu.Visible = false;
            pictureBoxlogo.Visible = true;
        }

        //Puan kullan (Evet) radio butonu seçildiğinde; 
        //Eğer puanı var ise puan kullanım alanını gösteriyoruz, logoyu gizliyoruz
        //Eğer puanı yok ise hata mesajı veriyoruz
        private void rbPuanKullanEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (musteriBilgileri.bonusPuan > 0)
            {
                groupBoxpuantablosu.Visible = true;
                pictureBoxlogo.Visible = false;
            }
            else
            {
                MessageBox.Show("Bonus Puanınız Yok !");
            }
        }
    }
}