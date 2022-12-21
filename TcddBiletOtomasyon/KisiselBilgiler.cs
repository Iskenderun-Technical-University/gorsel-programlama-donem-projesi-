namespace TcddBiletOtomasyon
{
    public class KisiselBilgiler : YolcuFiyat
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public long tc { get; set; }
        public decimal bakiye { get; set; }
        public decimal bonusPuan { get; set; }
        public decimal toplamTutar { get; set; }
        public bool ogrenciMi { get; set; }
        public bool tekyonMu { get; set; }
        public DateTime gidisTarihi { get; set; }
        public DateTime donusTarihi { get; set; }
        public string nereden { get; set; }
        public string nereye { get; set; }
        public int yolcuSayisi { get; set; }
        public int no { get; set; }
        public decimal formlarArasiToplamTutar { get; set; }
        public KisiselBilgiler()
        {
            bakiye = 1000;
            bonusPuan = 250;
        }
    }
}
