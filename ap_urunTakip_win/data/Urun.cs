namespace ap_urunTakip_win.data
{
    public class Urun
    {
        private int _id;
        private string urun_adi;
        private decimal fiyati;
        private int stok;
        private int satilanMiktar;
        private char paraBirimi;
        public Urun()
        {
        }
        public override string ToString()
        {
            return urun_adi + ", stok: " + stok + ", satilan: " + satilanMiktar;
        }
        public Urun(int id, string urun_adi, int stok, int satis, decimal fiyati, char paraBr)
        {
            _id = id;
            this.urun_adi = urun_adi;
            this.fiyati = fiyati;
            this.stok = stok;
            satilanMiktar = satis;
            paraBirimi = paraBr;

        }

        public string Urun_adi { get => urun_adi; set => urun_adi = value; }
        public decimal Fiyati { get => fiyati; set => fiyati = value; }
        public int Id { get => _id; set => _id = value; }
        public int Stok { get => stok; set => stok = value; }
        public char ParaBirimi { get => paraBirimi; set => paraBirimi = value; }
        public int SatilanMiktar { get => satilanMiktar; set => satilanMiktar = value; }
    }
}
