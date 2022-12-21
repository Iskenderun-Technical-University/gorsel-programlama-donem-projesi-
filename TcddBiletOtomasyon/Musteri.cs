namespace TcddBiletOtomasyon
{
    public class Musteri
    {
        //Singleton
        //Musteri null ise yeni bir obje oluşturuyoruz,
        //elimizde oluşturulmuş bir Musteri objesi var ise onu kullanıyoruz
        private static Musteri musteri;
        public static Musteri getir
        {
            get
            {
                if (musteri == null)
                    musteri = new Musteri();
                return musteri;
            }
            set { musteri = value; }
        }

        public int musteriNo { get; set; }

        public List<MusteriBilgileri> listMusteriBilgileri { get; set; }

        //constructor (yapıcı) metod
        public Musteri()
        {
            listMusteriBilgileri = new List<MusteriBilgileri>();
            musteriNo = 0;
        }

        //Müşteri bilgilerini listeleyen metod
        public string MusterileriListele()
        {
            //ilk bilet numarası 1 den başlıyor
            int biletNumarasi = 1;
            string mesaj = "";


            //Müşteri bilgileri listesini foreach ile dönüyoruz
            foreach (MusteriBilgileri mus in listMusteriBilgileri)
            {
                //Her müşterinin bilgilerini doldurup mesaj string değişkenine ekliyoruz
                mesaj += "\n----------------------" +
                        "\nBilet No\t: (" + biletNumarasi.ToString() + ")" +
                        "\n-Tutar   \t: " + mus.formlarArasiToplamTutar.ToString() + " TL" +
                        "\n-İsim    \t: " + mus.isim +
                        "\n-Soyisim \t: " + mus.soyisim +
                        "\n-Email   \t: " + mus.email +
                        "\n-TC      \t: " + mus.tc.ToString() + 
                        "\n-Kalan Bakiye  \t: " + mus.bakiye.ToString() + " TL" +
                        "\n-Kalan Puan    \t: " + mus.bonusPuan.ToString() + " TL" +
                        "\n----------------------";
                //Her müşteri bilgilerini eklememizde bilet numarasını bir arttırıyoruz
                biletNumarasi++;
            }

            //mesaj += "\n-Kalan Bakiye  \t: " + mus.bakiye.ToString() + " TL" +
            //    "\n-Kalan Puan    \t: " + mus.bonusPuan.ToString() + " TL";

            //oluşturduğumuz müşteri bilgileri stringini dönüyoruz
            return mesaj;
        }


        //Müşteriyi tc'si ile bulup bakiyesini dönen metod
        public decimal BakiyeBUL(long tc)
        {
            decimal bakiye = 0;
            //Müşteri bilgileri listesini foreach ile dönüyoruz
            foreach (MusteriBilgileri musteriBilgileri in listMusteriBilgileri)
            {
                //Müşteri tc kontrolü
                if (musteriBilgileri.tc == tc)
                {
                    bakiye= musteriBilgileri.bakiye;
                }
            }
            return bakiye;
        }

        //Müşteriyi tc'si ile bulup bonus puanını dönen metod
        public decimal BonusPuanBUL(long girenmusteriTC)
        {
            decimal bonusPuan = 0;
            //Müşteri bilgileri listesini foreach ile dönüyoruz
            foreach (MusteriBilgileri musteriBilgileri in listMusteriBilgileri)
            {
                //Müşteri tc kontrolü
                if (musteriBilgileri.tc == girenmusteriTC)
                {
                    bonusPuan = musteriBilgileri.bonusPuan;
                }
            }
            return bonusPuan;
        }
    }
}