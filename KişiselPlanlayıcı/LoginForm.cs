using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KişiselPlanlayıcı
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnSecimOturum_Click(object sender, EventArgs e)
        {
            pnlOturumAc.Visible = true;
            pnlKayitOl.Visible = false;

            // Görsel efekt: Hangi butonun aktif olduğu belli olsun
            btnSecimOturum.BackColor = Color.MediumPurple; // Aktif renk
            btnSecimKayit.BackColor = Color.White;
        }

        private void btnSecimKayit_Click(object sender, EventArgs e)
        {
            pnlOturumAc.Visible = false;  // Oturum panelini gizle
            pnlKayitOl.Visible = true;    // Kayıt panelini göster

            // Görsel efekt
            btnSecimKayit.BackColor = Color.MediumPurple;  // Aktif renk
            btnSecimOturum.BackColor = Color.White;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // İlk açılışta Oturum Aç paneli görünsün
            pnlOturumAc.Visible = true;
            pnlKayitOl.Visible = false;

            // Hatırlatma kontrolü: Eğer önceden "Beni Hatırla" seçilmişse bilgileri doldur
            if (Properties.Settings.Default.BeniHatirlaDurum == true)
            {
                txtGirisKullanici.Text = Properties.Settings.Default.SonGirisYapanKullanici;
                txtGirisSifre.Text = Properties.Settings.Default.KayitliSifre;
                hatırlatmaCheckBox.Checked = true;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string girilenKadi = txtGirisKullanici.Text;
            string girilenSifre = txtGirisSifre.Text;

            // Kayıtlı verileri Settings'ten çekiyoruz
            

            if (Properties.Settings.Default.KullaniciListesi == null || Properties.Settings.Default.KullaniciListesi.Count == 0)
            {
                MessageBox.Show("Sistemde hiç kayıtlı kullanıcı yok!");
                return;
            }

            bool bulunduMu = false;

            foreach (string kayit in Properties.Settings.Default.KullaniciListesi)
            {
                string[] parcalar = kayit.Split(':'); // "Kadi:Sifre" formatını parçala
                string kayitliKadi = parcalar[0];
                string kayitliSifre = parcalar[1];

                if (girilenKadi == kayitliKadi && girilenSifre == kayitliSifre)
                {
                    bulunduMu = true;
                    break;
                }
            }

            if (bulunduMu)
            {
                // Giriş yapan ismi HER DURUMDA kaydediyoruz ki AnaEkran'da görünsün
                Properties.Settings.Default.SonGirisYapanKullanici = girilenKadi;

                if (hatırlatmaCheckBox.Checked)
                {
                    Properties.Settings.Default.BeniHatirlaDurum = true;
                    Properties.Settings.Default.KayitliSifre = girilenSifre;
                }
                else
                {
                    // Kutucuk seçili değilse sadece hatırlama ayarlarını kapatıyoruz
                    // İSİM SİLME SATIRINI BURADAN KALDIRDIK
                    Properties.Settings.Default.BeniHatirlaDurum = false;
                    Properties.Settings.Default.KayitliSifre = "";
                }

                // Tüm ayarları tek seferde kaydediyoruz
                Properties.Settings.Default.Save();

                MessageBox.Show("Giriş Başarılı!");
                AnaEkran anaForm = new AnaEkran();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yeniKadi = txtKayitKullanici.Text;
            string yeniSifre = txtKayitSifre.Text;
            if (yeniSifre.Length >= 4 && yeniSifre.Any(char.IsDigit) && yeniSifre.Any(char.IsUpper))
            {
                // Koleksiyonu başlat (Eğer ilk kez kullanılıyorsa null olur)
                if (Properties.Settings.Default.KullaniciListesi == null)
                    Properties.Settings.Default.KullaniciListesi = new System.Collections.Specialized.StringCollection();

                // Bu kullanıcı daha önce alınmış mı kontrol et
                foreach (string kayit in Properties.Settings.Default.KullaniciListesi)
                {
                    if (kayit.Split(':')[0] == yeniKadi)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten alınmış!");
                        return;
                    }
                }

                // Kullanıcıyı "KullaniciAdi:Sifre" formatında listeye ekle
                Properties.Settings.Default.KullaniciListesi.Add(yeniKadi + ":" + yeniSifre);
                Properties.Settings.Default.Save();

                MessageBox.Show("Yeni kullanıcı başarıyla eklendi!");
                pnlOturumAc.BringToFront();
            }
            else
            {
                MessageBox.Show("Şifre kurallara uymuyor!");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Eğer bu Login formuysa komple uygulamayı kapatır
            // Eğer ana formun içindeki bir pencereyse sadece o pencereyi kapatır
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
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

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
