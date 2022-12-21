namespace TcddBiletOtomasyon
{
    public class YolcuFiyat
    {
        //Encapsulation (Kapsülleme)
        //fiyatOgrenci değişkenimizi direkt erişimi kısıtladık,
        //ogrenciFiyat erişim belirtecinin get ve set metodları ile erişim sağlanabilir
        protected decimal fiyatOgrenci;
        public decimal ogrenciFiyat
        {
            get { return fiyatOgrenci; }
            set { fiyatOgrenci = value; }
        }


        //Encapsulation (Kapsülleme)
        //fiyatTam değişkenimizi direkt erişimi kısıtladık,
        //tamFiyat erişim belirtecinin get ve set metodları ile erişim sağlanabilir
        protected decimal fiyatTam;
        public decimal tamFiyat
        {
            get { return fiyatTam; }
            set { fiyatTam = value; }
        }

        //Bilet fiyatlarını set ettiğimiz virtual (sanal) bir metod
        public YolcuFiyat()
        {
            tamFiyat = 200;
            ogrenciFiyat = 180;
        }
    }
}
