namespace TcddBiletOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Singleton
        //Form1 null ise yeni bir obje oluşturuyoruz,
        //elimizde oluşturulmuş bir Form1 objesi var ise onu kullanıyoruz
        private static Form1 form1;
        public static Form1 getir
        {
            get
            {
                if (form1 == null)
                    form1 = new Form1();
                return form1;
            }
            set { form1 = value; }
        }

        public long tc;
        OdemeEkrani odemeEkrani = new OdemeEkrani();

        //Form1 ilk yüklendiğinde;
        //müşteri numarasını setliyoruz
        //nereden, nereye comboBoxlarının seçili gelmesi için setliyoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            cbNereden.SelectedIndex = 0;
            cbNereye.SelectedIndex = 1;
            dpGidisTarihi.Value = DateTime.Now;
            dpDonusTarihi.Value = DateTime.Today.AddDays(1);
        }

        private bool formGecerliMi()
        {
            bool formGecerli = false;

            if (rbOgrenci.Checked == false && tbTam.Checked == false)
            {
                rbOgrenci.BackColor = Color.PaleVioletRed;
                tbTam.BackColor = Color.PaleVioletRed;
                MessageBox.Show("HATA: Bilet türünüz hatalı. Kontrol ediniz..");
            }
            else if (rbGidisDonus.Checked == false && rbTekyon.Checked == false)
            {
                rbGidisDonus.BackColor = Color.PaleVioletRed;
                rbTekyon.BackColor = Color.PaleVioletRed;
                MessageBox.Show("HATA: Yön seçiminiz hatalı. Kontrol ediniz..");
            }
            else if (cbNereden.SelectedItem == cbNereye.SelectedItem)
            {
                cbNereden.BackColor = Color.PaleVioletRed;
                cbNereye.BackColor = Color.PaleVioletRed;
                MessageBox.Show("HATA: Kalkış-Varış Noktaları aynı olamaz..");
            }
            else if (numYolcuSayisi.Value == 0)
            {
                numYolcuSayisi.BackColor = Color.PaleVioletRed;
                MessageBox.Show("HATA: Yolcu sayısını kontrol ediniz..");
            }
            else if (String.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("HATA: Ad bilgisi boş geçilemez..");
            }
            else if (String.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("HATA: Soyadı bilgisi boş geçilemez..");
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("HATA: E-Mail bilgisi boş geçilemez..");
            }
            else if (txtEmail.Text.Contains("@") == false)
            {
                MessageBox.Show("HATA: E-Mail bilgisi @ işareti içermeli..");
            }
            else if (txtTc.TextLength < 11)
            {
                MessageBox.Show("TC 11 rakamdan oluşmalı..");
            }
            else if (rbGidisDonus.Checked == true && dpGidisTarihi.Text == dpDonusTarihi.Text)
            {
                MessageBox.Show("HATA: Aynı gün sadece 12:00'de seferlerimiz vardır.\nGidis - Dönüş seferlerde gidiş ve dönüş tarihi aynı olamaz..");
            }
            else
            {
                formGecerli = true;
            }

            return formGecerli;
        }

        //btnDevam butonuna tıklanıldığında çalışacak metod
        private void button1_Click(object sender, EventArgs e)
        {
            //Singleton müşteriBilgileri objesini alıyoruz
            MusteriBilgileri musteriBilgileri = MusteriBilgileri.getir;

            //Formda girilen bilgileri musteriBilgileri objemize set ediyoruz
            musteriBilgileri.gidisTarihi = dpGidisTarihi.Value;
            musteriBilgileri.donusTarihi = dpDonusTarihi.Value;
            musteriBilgileri.nereden = cbNereden.SelectedItem.ToString();
            musteriBilgileri.nereye = cbNereye.SelectedItem.ToString();

            if (formGecerliMi())
            {
                musteriBilgileri.no = Musteri.getir.musteriNo;
                tc = Convert.ToInt64(txtTc.Text);
                musteriBilgileri.yolcuSayisi = Convert.ToInt32(numYolcuSayisi.Value);
                musteriBilgileri.tekyonMu = rbTekyon.Checked;
                musteriBilgileri.ogrenciMi = rbOgrenci.Checked;
                musteriBilgileri.isim = txtAd.Text;
                musteriBilgileri.soyisim = txtSoyad.Text;
                musteriBilgileri.tc = Convert.ToInt64(txtTc.Text);
                musteriBilgileri.email = txtEmail.Text;
                musteriBilgileri.numericSayi = Convert.ToInt32(numYolcuSayisi.Value);
                musteriBilgileri.toplamTutar = musteriBilgileri.hesaplanmisTutar;


                Musteri.getir.listMusteriBilgileri.Add(new MusteriBilgileri()
                {
                    isim = txtAd.Text,
                    soyisim = txtSoyad.Text,
                    email = txtEmail.Text,
                    tc = Convert.ToInt64(txtTc.Text),
                    toplamTutar = musteriBilgileri.hesaplanmisTutar,
                    ogrenciMi = rbOgrenci.Checked,
                    tekyonMu = rbTekyon.Checked,
                    nereden = cbNereden.SelectedItem.ToString(),
                    nereye = cbNereye.SelectedItem.ToString(),
                    gidisTarihi = Convert.ToDateTime(dpGidisTarihi.Text),
                    donusTarihi = Convert.ToDateTime(dpDonusTarihi.Text),
                    no = Musteri.getir.musteriNo,
                    bonusPuan = Musteri.getir.musteriNo > 0 ? Musteri.getir.listMusteriBilgileri[Musteri.getir.musteriNo-1].bonusPuan : musteriBilgileri.bonusPuan,
                    bakiye = Musteri.getir.musteriNo > 0 ? Musteri.getir.listMusteriBilgileri[Musteri.getir.musteriNo-1].bakiye : musteriBilgileri.bakiye
                });

                this.Hide();
                odemeEkrani.Show();
            }
        }

        //Gidiş-Dönüş radio butonu seçildiğinde; dönüş tarihi alanını enable ediyoruz
        private void gdRadio_CheckedChanged(object sender, EventArgs e)
        {
            dpDonusTarihi.Enabled = true;
        }

        //Tek yön radio butonu seçildiğinde; dönüş tarihi alanını disable ediyoruz
        private void tyRadio_CheckedChanged(object sender, EventArgs e)
        {
            dpDonusTarihi.Enabled = false;
        }

        //ad alanına sadece harf ve boşluk karakteri girişi yapılabilmesi için sınırlıyoruz
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        //soyad alanına sadece harf girişi yapılabilmesi için sınırlıyoruz
        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        //Tc alanına sadece sayı girişi yapılabilmesi için sınırlıyoruz
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
