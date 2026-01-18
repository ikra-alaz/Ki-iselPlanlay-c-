using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KişiselPlanlayıcı
{
    public partial class TakvimForm : Form
    {
        public List<HedefKarti> GelenHedefler { get; set; }

        public TakvimForm()
        {
            InitializeComponent();
        }

        private void TakvimForm_Load(object sender, EventArgs e)
        {
            // Takvim boyutlandırma
            mtcTakvim.Scale(new SizeF(2.0f, 2.0f));
            mtcTakvim.Location = new Point(0, 125);

            // Form açılır açılmaz takvimi işaretle ve bugünü listele
            TakvimiIsaretle();
            TariheGoreListele(DateTime.Today);
        }

        private void TariheGoreListele(DateTime secilenTarih)
        {
            flpGunlukDetay.Controls.Clear(); // Paneli temizle

            if (GelenHedefler == null) return;

            // 1. O GÜN SON TARİHİ (DEADLINE) OLANLAR -> KIRMIZI
            var sonGunuOlanlar = GelenHedefler
                .Where(h => h.Tarih.Date == secilenTarih.Date)
                .ToList();

            // 2. O GÜN TAMAMLANANLAR -> LİLA
            var oGunYapilanlar = GelenHedefler
                .Where(h => h.TamamlanmaTarihleri.Any(t => t.Date == secilenTarih.Date))
                .ToList();

            // VERİ KONTROLÜ
            if (sonGunuOlanlar.Count == 0 && oGunYapilanlar.Count == 0)
            {
                Label lblBilgi = new Label
                {
                    Text = "Bu tarihte bir işlem bulunamadı. ✨",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Margin = new Padding(20)
                };
                flpGunlukDetay.Controls.Add(lblBilgi);
                return;
            }

            // ÖNCE: Son teslim tarihi gelenleri KIRMIZI olarak ekle
            foreach (var h in sonGunuOlanlar)
            {
                MiniKartOlustur("⏰ SON GÜN: " + h.Baslik, h.Siklik, Color.Red);
            }

            // SONRA: Tamamlananları LİLA olarak ekle
            foreach (var h in oGunYapilanlar)
            {
                MiniKartOlustur("✓ " + h.Baslik, "Tamamlandı (" + h.Siklik + ")", Color.FromArgb(176, 166, 219));
            }
        }

        // Renk parametresi eklenmiş, estetik Mini Kart metodu
        private void MiniKartOlustur(string baslik, string altBilgi, Color vurguRengi)
        {
            Panel pnl = new Panel
            {
                Size = new Size(flpGunlukDetay.Width - 40, 60),
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10)
            };

            // Sol renkli çizgi (Kırmızı veya Lila)
            Panel pnlCizgi = new Panel
            {
                Size = new Size(7, 60),
                BackColor = vurguRengi,
                Dock = DockStyle.Left
            };

            Label lbl = new Label
            {
                Text = baslik,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = vurguRengi == Color.Red ? Color.Red : Color.Black,
                Location = new Point(20, 10),
                AutoSize = true
            };

            Label lblAlt = new Label
            {
                Text = altBilgi,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.DimGray,
                Location = new Point(20, 32),
                AutoSize = true
            };

            pnl.Controls.Add(lbl);
            pnl.Controls.Add(lblAlt);
            pnl.Controls.Add(pnlCizgi);
            flpGunlukDetay.Controls.Add(pnl);
        }

        private void mtcTakvim_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Tarih değiştiğinde listeyi güncelle
            TariheGoreListele(e.Start.Date);
        }

        private void TakvimiIsaretle()
        {
            if (GelenHedefler == null) return;

            // Tamamlanan günler + Bitiş tarihleri (Deadline)
            var tumOzelTarihler = GelenHedefler
                .SelectMany(h => h.TamamlanmaTarihleri)
                .Select(t => t.Date)
                .Union(GelenHedefler.Select(h => h.Tarih.Date))
                .Distinct()
                .ToArray();

            mtcTakvim.BoldedDates = tumOzelTarihler;
            mtcTakvim.UpdateBoldedDates();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
