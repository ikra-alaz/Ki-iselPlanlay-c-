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
    public partial class frmGorevDetay : Form
    {
        public string GelenBaslik { get; set; }
        public string GelenDetay { get; set; }
        public DateTime GelenTarih { get; set; }
        public string GelenSiklik { get; set; }
        public frmGorevDetay()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Boş alan kontrolü yapalım(Hata almamak için)
    if (string.IsNullOrEmpty(txtBaslik.Text))
            {
                MessageBox.Show("Lütfen bir başlık giriniz!");
                return;
            }

            // 2. Formdaki bilgileri değişkenlere aktaralım
            GelenBaslik = txtBaslik.Text;
            GelenDetay = txtDetay.Text;
            GelenTarih = dtpTarih.Value;
            GelenSiklik = cmbSiklik.SelectedItem?.ToString() ?? "Belirtilmedi";

            // 3. Formun başarıyla tamamlandığını ana forma bildir
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
