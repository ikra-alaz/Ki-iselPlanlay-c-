using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KişiselPlanlayıcı
{
    public partial class PomodoroForm : Form
    {
        // Global Değişkenler
        int toplamSaniye;
        int kalanSaniye;
        bool molaModu = false;

        public PomodoroForm()
        {
            InitializeComponent();

            // Timer Ayarı
            timerPomodoro.Interval = 1000; // 1 saniye

            // ProgressBar Başlangıç Ayarı
            circularProgressBar1.Minimum = 0;

            // Form ilk açıldığında varsayılan (25:05) yükle
            numCalisma.Value = 25;
            numMola.Value = 5;
            SureyiSifirla();
        }

        private void SureyiSifirla()
        {
            timerPomodoro.Stop();
            molaModu = false;
            btnBaslat.Text = "BAŞLAT";
            this.BackColor = Color.FromArgb(176, 166, 219); // Lila

            // Süreleri hesapla
            int calismaDk = (int)numCalisma.Value;
            toplamSaniye = calismaDk * 60;
            kalanSaniye = toplamSaniye;

            // --- PROGRESS BAR GÜNCELLEME (SIRA ÖNEMLİ) ---
            circularProgressBar1.Value = 0; // Önce sıfırla
            circularProgressBar1.Maximum = toplamSaniye; // Sonra sınırı genişlet (120 dk için 7200 yapar)
            circularProgressBar1.Value = toplamSaniye; // Şimdi doldur

            // Label güncelle
            lblSayac.Text = string.Format("{0:D2}:00", calismaDk);
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (timerPomodoro.Enabled)
            {
                timerPomodoro.Stop();
                btnBaslat.Text = "DEVAM ET";
            }
            else
            {
                // Eğer bir şekilde süre bittiyse ve tekrar basıldıysa sıfırla
                if (kalanSaniye <= 0) SureyiSifirla();

                timerPomodoro.Start();
                btnBaslat.Text = "DURDUR";
            }
        }

        private void timerPomodoro_Tick(object sender, EventArgs e)
        {
            if (kalanSaniye > 0)
            {
                kalanSaniye--;

                // Progress Bar senkronizasyonu
                circularProgressBar1.Value = kalanSaniye;

                TimeSpan t = TimeSpan.FromSeconds(kalanSaniye);
                int toplamDakika = (int)t.TotalMinutes;

                // --- DİNAMİK FONT AYARI ---
                // Dakika 3 haneliyse (100+) fontu 30 yap, değilse 45 yap
                if (toplamDakika >= 100)
                {
                    lblSayac.Font = new Font("Arial Narrow", 59f, FontStyle.Bold);
                }
                else
                {
                    lblSayac.Font = new Font("Arial Narrow", 69f, FontStyle.Bold);
                }

                // Yazıyı yazdır
                lblSayac.Text = string.Format("{0:D2}:{1:D2}", toplamDakika, t.Seconds);
            }
            else
            {
                timerPomodoro.Stop();
                MolaGecisi();
            }
        }

        private void MolaGecisi()
        {
            if (!molaModu) // Çalışma bitti -> Mola başlıyor
            {
                molaModu = true;
                int molaDk = (int)numMola.Value;
                kalanSaniye = molaDk * 60;

                // Progress bar'ı mola süresine göre ayarla
                circularProgressBar1.Value = 0;
                circularProgressBar1.Maximum = kalanSaniye;
                circularProgressBar1.Value = kalanSaniye;

                
                lblSayac.Text = string.Format("{0:D2}:00", molaDk);

                MessageBox.Show("Çalışma seansı bitti! Dinlenme zamanı. ✨", "Mola Vakti");
                timerPomodoro.Start();
            }
            else // Mola bitti -> Tekrar çalışmaya hazırla
            {
                MessageBox.Show("Mola bitti! Yeni bir seansa hazır mısın?", "Süre Doldu");
                SureyiSifirla();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Paneldeki değerleri uygula ve paneli kapat
            SureyiSifirla();
            pnlAyarlar.Visible = false;
        }

        private void btnAyarla_Click(object sender, EventArgs e)
        {
            // Ayarlar panelini aç/kapat
            pnlAyarlar.Visible = !pnlAyarlar.Visible;
            if (pnlAyarlar.Visible) pnlAyarlar.BringToFront();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            SureyiSifirla();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
