using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ap_urunTakip_win.data
{
    public class Content
    {
        static IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "9U4yrWplBMZIIJzl1MFigPB1ugrbO5pzav9htA2P",
            BasePath = "https://uruntakipdb-467fc-default-rtdb.firebaseio.com/"
        };

        static IFirebaseClient client = new FirebaseClient(config: fc);
        public static int lastUrunID = 0;
        public static int lastSatisID = 0;

        public static bool UrunEkle(Urun model)
        {
            model.Id = lastUrunID;
            try
            {
                client.Set("tbl_urunler/" + model.Id, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool UrunGuncelle(Urun model)
        {
            try
            {
                client.Update("tbl_urunler/" + model.Id, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool UrunSil(int id)
        {
            try
            {
                client.Delete("tbl_urunler/" + id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static List<Urun> UrunListele()
        {
            //List<Urun> kayitlar = new List<Urun>();
            List<Urun> list = new List<Urun>();
            FirebaseResponse res = client.Get(@"tbl_urunler");
            try
            {
                var kayitlar = JsonConvert.DeserializeObject<List<Urun>>(res.Body.ToString());
                if (kayitlar != null)
                {
                    foreach (var item in kayitlar)
                    {
                        if (item != null)
                        {
                            list.Add(item);
                        }

                    }
                }


            }
            catch (Exception)
            {
                var kayitlar = JsonConvert.DeserializeObject<Dictionary<string, Urun>>(res.Body.ToString());

                foreach (var item in kayitlar)
                {
                    Urun urn = item.Value;
                    list.Add(urn);
                }
            }
            if (list != null & list.Count != 0)
            {
                lastUrunID = list[list.Count - 1].Id + 1;
            }
            return list;
        }
        public static Urun UrunAra(int id)
        {
            Urun kayit = new Urun();
            try
            {
                FirebaseResponse res = client.Get(@"tbl_urunler/" + id);
                kayit = JsonConvert.DeserializeObject<Urun>(res.Body.ToString());
            }
            catch (Exception)
            {
                return kayit;
            }

            return kayit;
        }
        public static List<Urun> AdaGoreUrunAra(string str)
        {
            List<Urun> res = UrunListele();
            List<Urun> kayitlar = new List<Urun>();
            foreach (Urun item in res)
            {
                if (item.Urun_adi.ToLower() == str)
                {
                    kayitlar.Add(item);
                }
            }

            return kayitlar;
        }
        public static List<Urun> StokDetay()
        {
            List<Urun> res = UrunListele();
            res = res.OrderByDescending(x => x.Stok).ToList();
            return res;
        }

        public static List<Urun> FavUrunList()
        {
            List<Urun> temp = UrunListele();
            List<Urun> kayit = new List<Urun>();
            try
            {

                temp = temp.Where(x => x.SatilanMiktar > 0).OrderByDescending(x => x.SatilanMiktar).ToList();
                if (temp.Count >= 3)
                {
                    kayit.Add(temp[0]);
                    kayit.Add(temp[1]);
                    kayit.Add(temp[2]);
                }
                if (temp.Count == 2)
                {
                    kayit.Add(temp[0]);
                    kayit.Add(temp[1]);
                }
                if (temp.Count == 1)
                {
                    kayit.Add(temp[0]);
                }

            }
            catch (Exception)
            {
                return null;
            }


            return kayit;
        }


        public static bool SatisEkle(Satis model)
        {
            model.Id = lastSatisID;
            try
            {
                client.Set("tbl_satislar/" + model.Id, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool stokDus(List<Urun> uruns)
        {
            try
            {
                Urun temp;
                foreach (var item in uruns)
                {
                    temp = UrunAra(item.Id);
                    temp.Stok -= item.Stok;
                    temp.SatilanMiktar += item.Stok;
                    UrunGuncelle(temp);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static bool stokTopla(int id)
        {
            try
            {
                Urun temp = null;
                foreach (var item in SatisAra(id).Urunler)
                {
                    temp = UrunAra(item.Id);
                    if (temp != null)
                    {
                        temp.Stok += item.Stok;
                        temp.SatilanMiktar -= item.Stok;
                        UrunGuncelle(temp);
                    }


                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static bool SatisGuncelle(Satis model)
        {
            try
            {
                client.Update("tbl_satislar/" + model.Id, model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool SatisSil(int id)
        {
            try
            {
                stokTopla(id);
                client.Delete("tbl_satislar/" + id);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static List<Satis> SatisListele()
        {
            List<Satis> list = new List<Satis>();

            FirebaseResponse res = client.Get(@"tbl_satislar");
            try
            {
                var kayitlar = JsonConvert.DeserializeObject<List<Satis>>(res.Body.ToString());
                if (kayitlar != null)
                {
                    foreach (var item in kayitlar)
                    {
                        if (item != null)
                        {
                            list.Add(item);
                        }

                    }
                }

            }
            catch (Exception)
            {
                var kayitlar = JsonConvert.DeserializeObject<Dictionary<string, Satis>>(res.Body.ToString());

                foreach (var item in kayitlar)
                {
                    Satis sts = item.Value;
                    list.Add(sts);
                }
            }
            if (list != null & list.Count != 0)
            {
                lastSatisID = list[list.Count - 1].Id + 1;
            }
            return list;
        }
        public static Satis SatisAra(int id)
        {
            try
            {
                FirebaseResponse res = client.Get(@"tbl_satislar/" + id);
                Satis kayit = JsonConvert.DeserializeObject<Satis>(res.Body.ToString());
                return kayit;
            }
            catch (Exception)
            {
                return null;
                throw;
            }


        }
        public static List<Satis> UruneGoreSatisAra(string str)
        {
            List<Satis> res = SatisListele();
            List<Satis> kayitlar = new List<Satis>();
            foreach (Satis satis in res)
            {
                foreach (var item in satis.Urunler)
                {
                    if (item.Urun_adi.ToLower() == str)
                    {
                        kayitlar.Add(satis);
                    }
                }
            }

            return kayitlar;
        }
        public static string pdfDisaAktar(Satis x, string not)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string> { "#", "Marka", "Ürün Adı", "Birim Fiyat", "Adet", "Ara Toplam" };
                PdfPTable pdfTable = new PdfPTable(list.Count);

                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                string Logo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Georgia.TTF");
                BaseFont logo = BaseFont.CreateFont(Logo, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 100; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                                                      // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.



                foreach (var column in list)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(230, 240, 220); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    int i = 1;
                    foreach (var row in x.Urunler)
                    {

                        pdfTable.AddCell(new Phrase(i.ToString(), new Font(bf)));
                        i++;
                        pdfTable.AddCell(new Phrase(row.Urun_adi, new Font(bf)));
                        pdfTable.AddCell(new Phrase(row.Fiyati.ToString(), new Font(bf)));
                        pdfTable.AddCell(new Phrase(row.Stok.ToString(), new Font(bf)));
                        decimal ara = row.Fiyati * row.Stok;
                        pdfTable.AddCell(new Phrase(ara.ToString(), new Font(bf)));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Pdf dosyası oluşturulamadı!" + e, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    Paragraph p = new Paragraph("\n Demirci İdris Keskin\n", new Font(logo, 32));
                    pdfDoc.Add(p);
                    Paragraph sp = new Paragraph("Tarih: " + x.Tarih.ToString() + "\nÜrün Adedi: " + x.Urunler.Count.ToString() + "\n\n\n", new Font(bf));
                    pdfDoc.Add(sp);
                    pdfDoc.Add(pdfTable);
                    Paragraph res = new Paragraph("\nToplam: " + x.ToplamFiyat.ToString(), new Font(bf));
                    pdfDoc.Add(res);
                    Paragraph n = new Paragraph("\nNotlar: " + not, new Font(bf));
                    pdfDoc.Add(n);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + save.FileName, "İşlem Tamam");
                }
            }
            return save.FileName;
        }

    }
}
