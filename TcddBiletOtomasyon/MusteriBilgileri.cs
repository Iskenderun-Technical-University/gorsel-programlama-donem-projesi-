namespace TcddBiletOtomasyon
{
    public class MusteriBilgileri : KisiselBilgiler
    {

        //Singleton
        //MusteriBilgileri null ise yeni bir obje oluşturuyoruz,
        //elimizde oluşturulmuş bir musteriBilgileri objesi var ise onu kullanıyoruz
        private static MusteriBilgileri musteriBilgileri;
        public static MusteriBilgileri getir
        {
            get
            {
                if (musteriBilgileri == null)
                    musteriBilgileri = new MusteriBilgileri();
                return musteriBilgileri;
            }
            set { musteriBilgileri = value; }
        }
        public decimal hesaplanmisTutar { get; set; }
        public int numericSayi { get; set; }
        public decimal ToplamHesap()
        {
            decimal birimFiyat = ogrenciMi ? ogrenciFiyat : tamFiyat;
            int yonBilgisi = tekyonMu ? 1 : 2;
            hesaplanmisTutar = numericSayi * birimFiyat * yonBilgisi;
            return hesaplanmisTutar;
        }

        //constructor (yapıcı) metod
        public MusteriBilgileri() { }
    }
}
