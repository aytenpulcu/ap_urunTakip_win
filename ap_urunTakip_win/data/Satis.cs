using System;
using System.Collections.Generic;

namespace ap_urunTakip_win.data
{
    public class Satis
    {
        public Satis()
        {

        }
        public Satis(int id, List<Urun> urunler, decimal toplamFiyat, DateTime tarih, string teslimFisi, string not)
        {
            Id = id;
            Urunler = urunler;
            ToplamFiyat = toplamFiyat;
            Tarih = tarih;
            TeslimFisi = teslimFisi;
            Notlar = not;
        }
        public int Id { get; set; }
        public List<Urun> Urunler { get; set; }
        public decimal ToplamFiyat { get; set; }
        public DateTime Tarih { get; set; }
        public string TeslimFisi { get; set; }
        public string Notlar { get; set; }
    }
}
