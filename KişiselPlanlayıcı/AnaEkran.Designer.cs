namespace KişiselPlanlayıcı
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing) //üst sıınıftan gelen metodun alt sınıfta yeniden kullanılması
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnBuyut = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.yapılacaklar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuYapilacaklar = new System.Windows.Forms.Button();
            this.btnMenuTakvim = new System.Windows.Forms.Button();
            this.btnMenuRaporlar = new System.Windows.Forms.Button();
            this.btnMenuPomodoro = new System.Windows.Forms.Button();
            this.pnlYapilacaklarIcerik = new System.Windows.Forms.Panel();
            this.btnHedefEkle = new System.Windows.Forms.Button();
            this.flpHedefter = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlYapilacaklarIcerik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.panelBaslik.Controls.Add(this.btnKucult);
            this.panelBaslik.Controls.Add(this.btnBuyut);
            this.panelBaslik.Controls.Add(this.btnKapat);
            this.panelBaslik.Controls.Add(this.pictureBox1);
            this.panelBaslik.Controls.Add(this.lblKullaniciAdi);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(955, 57);
            this.panelBaslik.TabIndex = 0;
            this.panelBaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.Location = new System.Drawing.Point(876, -5);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(24, 37);
            this.btnKucult.TabIndex = 5;
            this.btnKucult.Text = "-";
            this.btnKucult.UseVisualStyleBackColor = false;
            // 
            // btnBuyut
            // 
            this.btnBuyut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnBuyut.FlatAppearance.BorderSize = 0;
            this.btnBuyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyut.Location = new System.Drawing.Point(898, -5);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(32, 37);
            this.btnBuyut.TabIndex = 4;
            this.btnBuyut.Text = "□";
            this.btnBuyut.UseVisualStyleBackColor = false;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(917, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(38, 29);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KişiselPlanlayıcı.Properties.Resources.logg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(66, 9);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(211, 39);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Hoş Geldin, ...";
            // 
            // yapılacaklar
            // 
            this.yapılacaklar.AutoSize = true;
            this.yapılacaklar.BackColor = System.Drawing.Color.White;
            this.yapılacaklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapılacaklar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yapılacaklar.Location = new System.Drawing.Point(30, 3);
            this.yapılacaklar.Name = "yapılacaklar";
            this.yapılacaklar.Size = new System.Drawing.Size(223, 46);
            this.yapılacaklar.TabIndex = 1;
            this.yapılacaklar.Text = "Hedeflerim!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.yapılacaklar);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnMenuYapilacaklar
            // 
            this.btnMenuYapilacaklar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuYapilacaklar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuYapilacaklar.FlatAppearance.BorderSize = 0;
            this.btnMenuYapilacaklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuYapilacaklar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuYapilacaklar.ForeColor = System.Drawing.Color.Black;
            this.btnMenuYapilacaklar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuYapilacaklar.Location = new System.Drawing.Point(62, 115);
            this.btnMenuYapilacaklar.Name = "btnMenuYapilacaklar";
            this.btnMenuYapilacaklar.Size = new System.Drawing.Size(136, 50);
            this.btnMenuYapilacaklar.TabIndex = 4;
            this.btnMenuYapilacaklar.Text = "Yapılacaklar";
            this.btnMenuYapilacaklar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuYapilacaklar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuYapilacaklar.UseVisualStyleBackColor = false;
            // 
            // btnMenuTakvim
            // 
            this.btnMenuTakvim.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuTakvim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuTakvim.FlatAppearance.BorderSize = 0;
            this.btnMenuTakvim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTakvim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuTakvim.ForeColor = System.Drawing.Color.Black;
            this.btnMenuTakvim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTakvim.Location = new System.Drawing.Point(189, 115);
            this.btnMenuTakvim.Name = "btnMenuTakvim";
            this.btnMenuTakvim.Size = new System.Drawing.Size(200, 50);
            this.btnMenuTakvim.TabIndex = 5;
            this.btnMenuTakvim.Text = "Takvim";
            this.btnMenuTakvim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTakvim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuTakvim.UseVisualStyleBackColor = false;
            this.btnMenuTakvim.Click += new System.EventHandler(this.btnMenuTakvim_Click);
            // 
            // btnMenuRaporlar
            // 
            this.btnMenuRaporlar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuRaporlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuRaporlar.FlatAppearance.BorderSize = 0;
            this.btnMenuRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRaporlar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuRaporlar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuRaporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRaporlar.Location = new System.Drawing.Point(287, 115);
            this.btnMenuRaporlar.Name = "btnMenuRaporlar";
            this.btnMenuRaporlar.Size = new System.Drawing.Size(200, 50);
            this.btnMenuRaporlar.TabIndex = 6;
            this.btnMenuRaporlar.Text = "Raporlar";
            this.btnMenuRaporlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuRaporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuRaporlar.UseVisualStyleBackColor = false;
            this.btnMenuRaporlar.Click += new System.EventHandler(this.btnMenuRaporlar_Click);
            // 
            // btnMenuPomodoro
            // 
            this.btnMenuPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuPomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPomodoro.FlatAppearance.BorderSize = 0;
            this.btnMenuPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPomodoro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuPomodoro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuPomodoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPomodoro.Location = new System.Drawing.Point(402, 115);
            this.btnMenuPomodoro.Name = "btnMenuPomodoro";
            this.btnMenuPomodoro.Size = new System.Drawing.Size(200, 50);
            this.btnMenuPomodoro.TabIndex = 7;
            this.btnMenuPomodoro.Text = "Hadi Çalışalım";
            this.btnMenuPomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPomodoro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuPomodoro.UseVisualStyleBackColor = false;
            this.btnMenuPomodoro.Click += new System.EventHandler(this.btnMenuPomodoro_Click);
            // 
            // pnlYapilacaklarIcerik
            // 
            this.pnlYapilacaklarIcerik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlYapilacaklarIcerik.Controls.Add(this.btnHedefEkle);
            this.pnlYapilacaklarIcerik.Controls.Add(this.flpHedefter);
            this.pnlYapilacaklarIcerik.Controls.Add(this.label2);
            this.pnlYapilacaklarIcerik.Location = new System.Drawing.Point(0, 168);
            this.pnlYapilacaklarIcerik.Name = "pnlYapilacaklarIcerik";
            this.pnlYapilacaklarIcerik.Size = new System.Drawing.Size(955, 478);
            this.pnlYapilacaklarIcerik.TabIndex = 8;
            // 
            // btnHedefEkle
            // 
            this.btnHedefEkle.FlatAppearance.BorderSize = 0;
            this.btnHedefEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHedefEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHedefEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHedefEkle.Location = new System.Drawing.Point(17, 37);
            this.btnHedefEkle.Name = "btnHedefEkle";
            this.btnHedefEkle.Size = new System.Drawing.Size(148, 30);
            this.btnHedefEkle.TabIndex = 3;
            this.btnHedefEkle.Text = "+ Yeni Hedef Ekle";
            this.btnHedefEkle.UseVisualStyleBackColor = true;
            this.btnHedefEkle.Click += new System.EventHandler(this.btnHedefEkle_Click);
            // 
            // flpHedefter
            // 
            this.flpHedefter.AutoScroll = true;
            this.flpHedefter.Location = new System.Drawing.Point(17, 70);
            this.flpHedefter.Name = "flpHedefter";
            this.flpHedefter.Padding = new System.Windows.Forms.Padding(20);
            this.flpHedefter.Size = new System.Drawing.Size(913, 395);
            this.flpHedefter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Günlük Hedeflerim";
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(955, 645);
            this.Controls.Add(this.pnlYapilacaklarIcerik);
            this.Controls.Add(this.btnMenuPomodoro);
            this.Controls.Add(this.btnMenuRaporlar);
            this.Controls.Add(this.btnMenuTakvim);
            this.Controls.Add(this.btnMenuYapilacaklar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBaslik);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.panelBaslik.ResumeLayout(false);
            this.panelBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlYapilacaklarIcerik.ResumeLayout(false);
            this.pnlYapilacaklarIcerik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBuyut;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Label yapılacaklar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuYapilacaklar;
        private System.Windows.Forms.Button btnMenuTakvim;
        private System.Windows.Forms.Button btnMenuRaporlar;
        private System.Windows.Forms.Button btnMenuPomodoro;
        private System.Windows.Forms.Panel pnlYapilacaklarIcerik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpHedefter;
        private System.Windows.Forms.Button btnHedefEkle;
    }
}

