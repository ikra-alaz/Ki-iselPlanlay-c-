
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KişiselPlanlayıcı
{
    public partial class AnaEkran : Form
    {
        // Formu sürüklemek için gerekli Windows API fonksiyonları
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //  listeMİZİ ve dosya yolunu tanımlayalım
        List<HedefKarti> tumHedefler = new List<HedefKarti>();
        string dosyaYolu = Path.Combine(Application.StartupPath, "hedeflerim.json");
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

            // Form yüklendiğinde çalışacak kodlar buraya
            Properties.Settings.Default.Reload();

            string isim = Properties.Settings.Default.SonGirisYapanKullanici;

            // Kontrol: Eğer isim boş değilse ve null değilse
            if (!string.IsNullOrEmpty(isim))
            {
                // İsmi temizle (başında sonunda boşluk varsa al)
                string temizIsim = isim.Trim();

                // İlk harfi büyük, geri kalanı olduğu gibi bırakalım (Hata riskini azaltmak için)
                string ilkHarf = temizIsim.Substring(0, 1).ToUpper();
                string gerisi = temizIsim.Substring(1);

                lblKullaniciAdi.Text = "Hoş geldin, " + ilkHarf + gerisi;
            }
            else
            {
                // Buraya düşüyorsa veri gerçekten boştur
                lblKullaniciAdi.Text = "Hoş geldin Misafir!";
            }
            MenüStiliniSıfırla();

            // "Yapılacaklar"ı varsayılan aktif buton yap
            btnMenuYapilacaklar.BackColor = Color.FromArgb(245, 242, 252); // Senin yeni arka planın
            btnMenuYapilacaklar.ForeColor = Color.FromArgb(176, 166, 219); // Ana lila rengin

            // Yapılacaklar içeriğinin olduğu paneli öne getir
            if (pnlYapilacaklarIcerik != null)
            {
                pnlYapilacaklarIcerik.BringToFront(); //bu satır kullanılmıyor panelde çalışmadık
            }

            // Formu ekranda düzgün ortala
            this.CenterToScreen();
            VerileriYukle(); //abstraction (soyutlama)
        }
        private void MenüStiliniSıfırla()
        {
            // Buton isimlerinin tasarım ekranındaki (Name) özelliğiyle aynı olduğundan emin ol
            List<Button> butonlar = new List<Button> {
        btnMenuYapilacaklar,
        btnMenuTakvim,
        btnMenuRaporlar,
        btnMenuPomodoro
    };

            foreach (var btn in butonlar)
            {
                if (btn != null)
                {
                    btn.BackColor = Color.Transparent; // Pasif durum (Şeffaf)
                    btn.ForeColor = Color.Black;       // Pasif yazı (siyah)
                }
            }
        }

        // Panelin MouseDown olayına bağlaman gereken metod
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnHedefEkle_Click(object sender, EventArgs e)
        {
            using (frmGorevDetay detayForm = new frmGorevDetay())
            {
                if (detayForm.ShowDialog() == DialogResult.OK)
                {
                    // 1. Yeni bir HedefKarti nesnesi oluştur ve listeye ekle
                    HedefKarti yeniHedef = new HedefKarti
                    {
                        Baslik = detayForm.GelenBaslik,
                        Detay = detayForm.GelenDetay,
                        Tarih = detayForm.GelenTarih,
                        Siklik = detayForm.GelenSiklik,
                        Tamamlandi = false,
                        Ilerleme = 0
                    };

                    tumHedefler.Add(yeniHedef); // Listeye ekledik

                    // 2. Ekranda görsel kartı oluştur
                    YeniKartOlustur(yeniHedef.Baslik, yeniHedef.Tarih, yeniHedef.Siklik, yeniHedef.Detay, false);

                    // 3. DOSYAYA KAYDET (En kritik nokta!)
                    VerileriKaydet();
                }
            }
        
        }
        private void YeniKartOlustur(string baslik, DateTime tarih, string siklik, string detay, bool bugunYapildiMi)
        {
            // 1. Kart Paneli
            Panel pnl = new Panel();
            pnl.Size = new Size(330, 150); // Boyutu biraz artırdım, CheckBox sığsın diye
            pnl.BackColor = Color.White;
            pnl.Margin = new Padding(15);
            pnl.BorderStyle = BorderStyle.None;

            // 2. Başlık
            Label lbl = new Label();
            lbl.Text = baslik;
            lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(64, 64, 64);
            lbl.Location = new Point(15, 10);
            lbl.AutoSize = true;

            // 3. Detay Metni
            Label lblDetay = new Label();
            lblDetay.Text = detay;
            lblDetay.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblDetay.ForeColor = Color.DimGray;
            lblDetay.Location = new Point(15, 35);
            lblDetay.Size = new Size(280, 40);
            lblDetay.AutoEllipsis = true;

            // 4. İlerleme Çubuğu
            ProgressBar pb = new ProgressBar();
            pb.Size = new Size(280, 8);
            pb.Location = new Point(15, 80);
            pb.Style = ProgressBarStyle.Continuous;
            pb.ForeColor = Color.FromArgb(176, 166, 219);

            // 5. Alt Bilgi (Sıklık ve Tarih)
            Label lblAlt = new Label();
            lblAlt.Text = siklik + " | Son: " + tarih.ToShortDateString();
            lblAlt.Font = new Font("Segoe UI", 8);
            lblAlt.ForeColor = Color.Gray;
            lblAlt.Location = new Point(15, 95);
            lblAlt.AutoSize = true;

            // 6. Silme Butonu
            Button btnSil = new Button();
            btnSil.Text = "X";
            btnSil.Size = new Size(25, 25);
            btnSil.Location = new Point(pnl.Width - 30, 5);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.ForeColor = Color.Red;
            btnSil.Font = new Font("Arial", 8, FontStyle.Bold);
            btnSil.Cursor = Cursors.Hand;

            btnSil.Click += (s, ev) =>
            {
                DialogResult onay = MessageBox.Show(baslik + " hedefini silmek istediğine emin misin?", "Hedefi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    var silinecek = tumHedefler.FirstOrDefault(x => x.Baslik == baslik);
                    if (silinecek != null) tumHedefler.Remove(silinecek);
                    flpHedefter.Controls.Remove(pnl);
                    pnl.Dispose();
                    VerileriKaydet();
                }
            }; // <--- btnSil.Click burada bitti

            // 7. Tamamlandı CheckBox
            CheckBox chkBitir = new CheckBox();
            chkBitir.Text = "Tamamlandı";
            chkBitir.Location = new Point(15, 115); // Yerini biraz aşağı aldım
            chkBitir.AutoSize = true;
            chkBitir.Checked = bugunYapildiMi;
            if (bugunYapildiMi) pb.Value = 100;

            chkBitir.CheckedChanged += (sender_chk, e_chk) =>
            {
                var h = tumHedefler.FirstOrDefault(x => x.Baslik == baslik);
                if (chkBitir.Checked)
                {
                    pb.Value = 100;
                    if (h != null) { h.Tamamlandi = true; h.Ilerleme = 100;
                        //  Eğer bugün bu hedef için daha önce kaydedilmemişse listeye ekle
                        if (!h.TamamlanmaTarihleri.Any(d => d.Date == DateTime.Today))
                        {
                            h.TamamlanmaTarihleri.Add(DateTime.Today);
                        }
                    }
                }
                else
                {
                    pb.Value = 0;
                    if (h != null) { h.Tamamlandi = false; h.Ilerleme = 0;
                        // Eğer kullanıcı tiki kaldırırsa bugünün kaydını listeden sil
                        var bugunKaydi = h.TamamlanmaTarihleri.FirstOrDefault(d => d.Date == DateTime.Today);
                        if (bugunKaydi != default)
                        {
                            h.TamamlanmaTarihleri.Remove(bugunKaydi);
                        }
                    }
                }
                VerileriKaydet();
            }; // <--- chkBitir.CheckedChanged burada bitti

            // 8. Elemanları karta ekle
            pnl.Controls.Add(lbl);
            pnl.Controls.Add(lblDetay);
            pnl.Controls.Add(pb);
            pnl.Controls.Add(lblAlt);
            pnl.Controls.Add(btnSil);
            pnl.Controls.Add(chkBitir);

            // Kartın kendisine tıklayınca detay göster
            pnl.Click += (s, ev) => {
                MessageBox.Show($"HEDEF: {baslik}\n\nYAPILACAKLAR:\n{detay}\n\nBİTİŞ: {tarih.ToShortDateString()}\nSIKLIK: {siklik}", "Hedef Detayları");
            };

            // 9. Kartı listeye ekle
            if (flpHedefter != null)
            {
                flpHedefter.Controls.Add(pnl);
            }
        }
        private void VerileriKaydet()
        {
            // tumHedefler listesini alıp dosyaya yazar
            string json = JsonConvert.SerializeObject(tumHedefler, Formatting.Indented);
            File.WriteAllText(dosyaYolu, json);
        }

        private void VerileriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                tumHedefler = JsonConvert.DeserializeObject<List<HedefKarti>>(json);

                // Daha önce eklenen kartları temizle (üst üste binmesin)
                flpHedefter.Controls.Clear();

                foreach (var h in tumHedefler)
                {
                    // Eğer bugün henüz tamamlanmadıysa görsel tiki kaldır
                    bool yapildi = h.TamamlanmaTarihleri.Any(d => d.Date == DateTime.Today);
                    // Kartı oluştururken bu bilgiyi kullanabilirsin
                    YeniKartOlustur(h.Baslik, h.Tarih, h.Siklik, h.Detay, yapildi);
                    // Kayıtlı her hedef için kartı ekranda oluştur
                    
                }
            }
        }

        private void btnMenuTakvim_Click(object sender, EventArgs e)
        {

            TakvimForm frm = new TakvimForm();
            // Ana ekrandaki listeyi takvim formuna gönderiyoruz ki orada gösterebilelim
            frm.GelenHedefler = this.tumHedefler;
            frm.Show();
        }

        private void btnMenuRaporlar_Click(object sender, EventArgs e)
        {
            RaporlarForm frm = new RaporlarForm();
            frm.GelenHedefler = this.tumHedefler;
            frm.ShowDialog();
        }

        private void btnMenuPomodoro_Click(object sender, EventArgs e)
        {
            PomodoroForm frm = new PomodoroForm();
            frm.Show();
        }
        
    }
    public class HedefKarti
    {
        public string Baslik { get; set; }
        public string Detay { get; set; }
        public DateTime Tarih { get; set; }
        public string Siklik { get; set; }
        public bool Tamamlandi { get; set; }
        public int Ilerleme { get; set; }
        //  Hangi günlerde tamamlandığını tutar
        public List<DateTime> TamamlanmaTarihleri { get; set; } = new List<DateTime>();
    }
}


