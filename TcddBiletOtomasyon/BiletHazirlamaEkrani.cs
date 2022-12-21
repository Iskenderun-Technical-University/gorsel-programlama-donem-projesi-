namespace TcddBiletOtomasyon
{
    public partial class BiletHazirlamaEkrani : Form
    {
        MusteriBilgileri musteriBilgileri;
        public BiletHazirlamaEkrani()
        {
            InitializeComponent();
        }

        private void BiletHazirlamaEkrani_Load(object sender, EventArgs e)
        {
            //Singleton müşteriBilgileri br musteri objelerini alıyoruz
            musteriBilgileri = MusteriBilgileri.getir;

            //Ödediği tutarın %10'u kadar bonus puan kazandı
            musteriBilgileri.bonusPuan += (musteriBilgileri.toplamTutar / 10);

            FormBilgileriniDoldur();
        }

        //Bu metod ile muşteri bilgilerini formda dolduruyoruz
        private void FormBilgileriniDoldur()
        {
            lblBiletNo.Text = (musteriBilgileri.no + 1).ToString();
            lblAd.Text = musteriBilgileri.isim;
            lblSoyad.Text = musteriBilgileri.soyisim;
            lblEmail.Text = musteriBilgileri.email;
            lblTc.Text = musteriBilgileri.tc.ToString();
            lblNereden.Text = musteriBilgileri.nereden;
            lblNereye.Text = musteriBilgileri.nereye;
            lblBiletTuru.Text = musteriBilgileri.ogrenciMi ? "Ogrenci" : "Tam";
            lblYolcuSayisi.Text = musteriBilgileri.yolcuSayisi.ToString();
            lblGidisTarihi.Text = musteriBilgileri.gidisTarihi.ToString();
            lblYonBilgisi.Text = musteriBilgileri.tekyonMu ? "Tek Yön" : "Gidiş-Dönüş";
            lblDonusTarihi.Text = !musteriBilgileri.tekyonMu ? musteriBilgileri.donusTarihi.ToString() : "-";
            lblBiletTutari.Text = musteriBilgileri.formlarArasiToplamTutar.ToString();
        }

        //Yeni rezervasyon butonuna tıklandığında çalışacak metod
        private void btnYeniRezervasyon_Click(object sender, EventArgs e)
        {
            //Müşteri numarasını bir arttırıp yeni bir bilet rezervasyon ekranı açıyoruz
            Musteri.getir.musteriNo++;
            Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        //Çıkış butonu tıklandığında çalışacak metod 
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();

        }

        //Müşteri listesine tıklandığında çalışacak metod 
        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Musteri.getir.MusterileriListele());
        }

     
        
    }
}
