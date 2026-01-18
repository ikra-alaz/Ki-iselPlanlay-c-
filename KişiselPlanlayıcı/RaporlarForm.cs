using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts; 
using LiveCharts.Wpf; 
using System.Windows.Media;

namespace KişiselPlanlayıcı
{
    public partial class RaporlarForm : Form
    {
        public List<HedefKarti> GelenHedefler { get; set; }
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            if (GelenHedefler == null || GelenHedefler.Count == 0)
            {
                MessageBox.Show("Henüz analiz edilecek veri yok. Biraz hedef ekleyip tamamlamaya ne dersin? ✨");
                return;
            }

            // 1. Üstteki Kartları Hesapla
            IstatistikKartlariniDoldur();

            // 2. Haftalık Gelişim Grafiğini Çiz (Spline Area)
            HaftalikGelisimGrafigi();

            // 3. Genel Durum Özetini Çiz (Halka)
            GenelDurumHalkasi();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IstatistikKartlariniDoldur()
        {
            int toplam = GelenHedefler.Count;
            int tamamlanan = GelenHedefler.Count(h => h.Tamamlandi);
            double oran = toplam > 0 ? (double)tamamlanan / toplam * 100 : 0;

            // Bu değerleri formdaki ilgili label'lara yazdır
            lblToplam.Text = $"Toplam Hedef: {toplam}";
            lblBasari.Text = $"Başarı Oranı: %{Math.Round(oran, 1)}";
        }
        private void HaftalikGelisimGrafigi()
        {
            pnlHaftalik.Controls.Clear();
            // Grafiği pnlHaftalik içine ekleyelim
            var cartesianChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.White
            };

            var gunler = new List<string>();
            var degerler = new ChartValues<int>();

            // Son 7 günün verisi
            for (int i = 6; i >= 0; i--)
            {
                DateTime tarih = DateTime.Today.AddDays(-i);
                int count = GelenHedefler.Count(h => h.TamamlanmaTarihleri.Any(d => d.Date == tarih.Date));

                degerler.Add(count);
                gunler.Add(tarih.ToString("dd MMM"));
            }

            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Tamamlanan",
                    Values = degerler,
                    PointGeometrySize = 12,
                    LineSmoothness = 0.6, // Kavisli çizgi
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(176, 166, 219)), // Lila
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(50, 176, 166, 219)) // Hafif dolgu
                }
            };

            // X Ekseni (Yatay - Gün İsimleri)
            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Günler",
                Labels = gunler
            });

            // Y Ekseni (Dikey - Sayılar)
            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Tamamlanan Adet",
                LabelFormatter = value => value.ToString("N0"),
                MinValue = 0
            });

            // Seriyi ekle
            cartesianChart.Series = new SeriesCollection
    {
        new LineSeries
        {
            Title = "Tamamlanan",
            Values = degerler,
            PointGeometrySize = 12,
            LineSmoothness = 0.6,
            Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(176, 166, 219)),
            Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(50, 176, 166, 219))
        }

             
    };       lblToplam.BringToFront();
            lblBasari.BringToFront();
            pnlHaftalik.Controls.Add(cartesianChart);
        }

        private void GenelDurumHalkasi()
        {
            pnlOzet.Controls.Clear();

            var pieChart = new LiveCharts.WinForms.PieChart
            {
                Dock = DockStyle.Fill,
                InnerRadius = 60,
                LegendLocation = LegendLocation.Bottom
            };

            // 2. Verileri taze listeden (GelenHedefler) tekrar say
            int bitti = GelenHedefler.Count(h => h.TamamlanmaTarihleri.Any(d => d.Date == DateTime.Today));
            int bekleyen = GelenHedefler.Count - bitti;

            // Eğer hiç hedef yoksa grafiğin hata vermemesi için kontrol (Opsiyonel)
            if (GelenHedefler.Count == 0) { bekleyen = 1; }

            pieChart.Series = new SeriesCollection
    {
        new PieSeries
        {
            Title = "Başarılan",
            Values = new ChartValues<int> { bitti },
            Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(176, 166, 219))
        },
        new PieSeries
        {
            Title = "Bekleyen",
            Values = new ChartValues<int> { bekleyen },
            Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(225, 225, 235))
        }
    };

            pnlOzet.Controls.Add(pieChart);
        }
    }
}
