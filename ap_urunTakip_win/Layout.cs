
using System;
using System.Windows.Forms;
using System.Linq;
using System.Net;

namespace ap.urunTakip_win
{
    public partial class Layout : Form
    {
        UserControl frm_urun;
        UserControl frm_urun2;
        UserControl frm_anasayfa;
        UserControl frm_satis;
        UserControl frm_ayarlar;
        decimal usd = 0, eu = 0;
        public Layout()
        {
            InitializeComponent();

            if (CheckForInternetConnection())
            {
                try
                {
                    HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();

                    HtmlAgilityPack.HtmlDocument doc = website.Load("https://mbigpara.hurriyet.com.tr/doviz/");
                    var dataDolar = doc.DocumentNode.SelectNodes("//li[@class='his3']").ToList()[5];
                    var dataEuro = doc.DocumentNode.SelectNodes("//li[@class='his3']").ToList()[9];
                    usd = Convert.ToDecimal(dataDolar.InnerText);
                    usd = Math.Round(usd, 2);
                    eu = Convert.ToDecimal(dataEuro.InnerText);
                    eu = Math.Round(eu, 2);

                }
                catch (Exception)
                {
                    MessageBox.Show("Kur bilgileri alınırken hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //frm_urun = new Urun_islemleri();
                //frm_urun2 = new KurBazliUrun_islemleri(usd, eu);
                //frm_anasayfa = new Anasayfa(usd, eu);
                //frm_satis = new Satis_islemleri(usd, eu);
                //frm_ayarlar = new ayarlar();

                //frm_urun.Dock = DockStyle.Fill;
                //frm_urun2.Dock = DockStyle.Fill;
                //frm_satis.Dock = DockStyle.Fill;
                //frm_anasayfa.Dock = DockStyle.Fill;
                //frm_ayarlar.Dock = DockStyle.Fill;

                //splitContainer1.Panel2.Controls.Add(frm_anasayfa);
                //splitContainer1.Panel2.Controls.Add(frm_urun);
                //splitContainer1.Panel2.Controls.Add(frm_urun2);
                //splitContainer1.Panel2.Controls.Add(frm_satis);
                //splitContainer1.Panel2.Controls.Add(frm_ayarlar);

            }
            else
            {
                MessageBox.Show("İnternet bağlantınız olmadığından veritabanına erişilemiyor ve kur bilgileri alınamıyor. Lütfen bağlatınızı kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label1.Visible=true;
                btn_anasayfa.Enabled=false;
                btn_Ayarlar.Enabled=false;
                btn_Satis.Enabled=false;
                btn_urun.Enabled=false;
                btn_urun2.Enabled=false;
            }



        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void btn_urun_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.SetChildIndex(frm_urun, 0);
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            //frm_anasayfa = new Anasayfa(usd, eu);
            //frm_anasayfa.Dock = DockStyle.Fill;

            //splitContainer1.Panel2.Controls.Add(frm_anasayfa);
            //splitContainer1.Panel2.Controls.SetChildIndex(frm_anasayfa, 0);
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2.Controls.SetChildIndex(frm_satis, 0);
        }

        private void btn_urun2_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2.Controls.SetChildIndex(frm_urun2, 0);
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2.Controls.SetChildIndex(frm_ayarlar, 0);
        }


    }
}
