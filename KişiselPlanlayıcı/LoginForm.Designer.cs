namespace KişiselPlanlayıcı
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnSecimKayit = new System.Windows.Forms.Button();
            this.btnSecimOturum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlOturumAc = new System.Windows.Forms.Panel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.şifreOturum = new System.Windows.Forms.Label();
            this.txtGirisKullanici = new System.Windows.Forms.TextBox();
            this.kullanıcıAdıOturum = new System.Windows.Forms.Label();
            this.pnlKayitOl = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.şifrekuralıKayıt = new System.Windows.Forms.Label();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.şifreKayıt = new System.Windows.Forms.Label();
            this.kullanıcıAdıKayıt = new System.Windows.Forms.Label();
            this.txtKayitKullanici = new System.Windows.Forms.TextBox();
            this.hatırlatmaCheckBox = new System.Windows.Forms.CheckBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBuyut = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOturumAc.SuspendLayout();
            this.pnlKayitOl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Snow;
            this.pnlLogin.Controls.Add(this.btnSecimKayit);
            this.pnlLogin.Controls.Add(this.btnSecimOturum);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.pnlOturumAc);
            this.pnlLogin.Controls.Add(this.pnlKayitOl);
            this.pnlLogin.Location = new System.Drawing.Point(81, 58);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(640, 484);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnSecimKayit
            // 
            this.btnSecimKayit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSecimKayit.Location = new System.Drawing.Point(190, 200);
            this.btnSecimKayit.Name = "btnSecimKayit";
            this.btnSecimKayit.Size = new System.Drawing.Size(95, 25);
            this.btnSecimKayit.TabIndex = 2;
            this.btnSecimKayit.Text = "Kayıt Ol";
            this.btnSecimKayit.UseVisualStyleBackColor = true;
            this.btnSecimKayit.Click += new System.EventHandler(this.btnSecimKayit_Click);
            // 
            // btnSecimOturum
            // 
            this.btnSecimOturum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSecimOturum.Location = new System.Drawing.Point(354, 200);
            this.btnSecimOturum.Name = "btnSecimOturum";
            this.btnSecimOturum.Size = new System.Drawing.Size(97, 25);
            this.btnSecimOturum.TabIndex = 1;
            this.btnSecimOturum.Text = "Oturum Aç";
            this.btnSecimOturum.UseVisualStyleBackColor = true;
            this.btnSecimOturum.Click += new System.EventHandler(this.btnSecimOturum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlOturumAc
            // 
            this.pnlOturumAc.Controls.Add(this.btnGirisYap);
            this.pnlOturumAc.Controls.Add(this.txtGirisSifre);
            this.pnlOturumAc.Controls.Add(this.şifreOturum);
            this.pnlOturumAc.Controls.Add(this.txtGirisKullanici);
            this.pnlOturumAc.Controls.Add(this.kullanıcıAdıOturum);
            this.pnlOturumAc.Location = new System.Drawing.Point(208, 231);
            this.pnlOturumAc.Name = "pnlOturumAc";
            this.pnlOturumAc.Size = new System.Drawing.Size(338, 253);
            this.pnlOturumAc.TabIndex = 0;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(14, 118);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(63, 29);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Location = new System.Drawing.Point(14, 81);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(195, 22);
            this.txtGirisSifre.TabIndex = 3;
            this.txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // şifreOturum
            // 
            this.şifreOturum.AutoSize = true;
            this.şifreOturum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.şifreOturum.Location = new System.Drawing.Point(11, 62);
            this.şifreOturum.Name = "şifreOturum";
            this.şifreOturum.Size = new System.Drawing.Size(40, 16);
            this.şifreOturum.TabIndex = 2;
            this.şifreOturum.Text = "Şifre :";
            // 
            // txtGirisKullanici
            // 
            this.txtGirisKullanici.Location = new System.Drawing.Point(14, 28);
            this.txtGirisKullanici.Name = "txtGirisKullanici";
            this.txtGirisKullanici.Size = new System.Drawing.Size(195, 22);
            this.txtGirisKullanici.TabIndex = 1;
            // 
            // kullanıcıAdıOturum
            // 
            this.kullanıcıAdıOturum.AutoSize = true;
            this.kullanıcıAdıOturum.BackColor = System.Drawing.Color.Snow;
            this.kullanıcıAdıOturum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kullanıcıAdıOturum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullanıcıAdıOturum.Location = new System.Drawing.Point(11, 9);
            this.kullanıcıAdıOturum.Name = "kullanıcıAdıOturum";
            this.kullanıcıAdıOturum.Size = new System.Drawing.Size(85, 16);
            this.kullanıcıAdıOturum.TabIndex = 0;
            this.kullanıcıAdıOturum.Text = "Kullanıcı Adı :";
            // 
            // pnlKayitOl
            // 
            this.pnlKayitOl.Controls.Add(this.label2);
            this.pnlKayitOl.Controls.Add(this.btnKaydet);
            this.pnlKayitOl.Controls.Add(this.şifrekuralıKayıt);
            this.pnlKayitOl.Controls.Add(this.txtKayitSifre);
            this.pnlKayitOl.Controls.Add(this.şifreKayıt);
            this.pnlKayitOl.Controls.Add(this.kullanıcıAdıKayıt);
            this.pnlKayitOl.Controls.Add(this.txtKayitKullanici);
            this.pnlKayitOl.Controls.Add(this.hatırlatmaCheckBox);
            this.pnlKayitOl.Location = new System.Drawing.Point(208, 231);
            this.pnlKayitOl.Name = "pnlKayitOl";
            this.pnlKayitOl.Size = new System.Drawing.Size(338, 253);
            this.pnlKayitOl.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(9, 165);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 28);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kayıt Ol";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // şifrekuralıKayıt
            // 
            this.şifrekuralıKayıt.AutoSize = true;
            this.şifrekuralıKayıt.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifrekuralıKayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.şifrekuralıKayıt.Location = new System.Drawing.Point(3, 106);
            this.şifrekuralıKayıt.Name = "şifrekuralıKayıt";
            this.şifrekuralıKayıt.Size = new System.Drawing.Size(256, 17);
            this.şifrekuralıKayıt.TabIndex = 5;
            this.şifrekuralıKayıt.Text = "Şifreniz en az 4 en fazla 10 karakter olmalı.";
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(14, 81);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(195, 22);
            this.txtKayitSifre.TabIndex = 4;
            this.txtKayitSifre.UseSystemPasswordChar = true;
            // 
            // şifreKayıt
            // 
            this.şifreKayıt.AutoSize = true;
            this.şifreKayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.şifreKayıt.Location = new System.Drawing.Point(11, 62);
            this.şifreKayıt.Name = "şifreKayıt";
            this.şifreKayıt.Size = new System.Drawing.Size(40, 16);
            this.şifreKayıt.TabIndex = 3;
            this.şifreKayıt.Text = "Şifre :";
            // 
            // kullanıcıAdıKayıt
            // 
            this.kullanıcıAdıKayıt.AutoSize = true;
            this.kullanıcıAdıKayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullanıcıAdıKayıt.Location = new System.Drawing.Point(11, 9);
            this.kullanıcıAdıKayıt.Name = "kullanıcıAdıKayıt";
            this.kullanıcıAdıKayıt.Size = new System.Drawing.Size(85, 16);
            this.kullanıcıAdıKayıt.TabIndex = 2;
            this.kullanıcıAdıKayıt.Text = "Kullanıcı Adı :";
            // 
            // txtKayitKullanici
            // 
            this.txtKayitKullanici.Location = new System.Drawing.Point(14, 28);
            this.txtKayitKullanici.Name = "txtKayitKullanici";
            this.txtKayitKullanici.Size = new System.Drawing.Size(195, 22);
            this.txtKayitKullanici.TabIndex = 1;
            // 
            // hatırlatmaCheckBox
            // 
            this.hatırlatmaCheckBox.AutoSize = true;
            this.hatırlatmaCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatırlatmaCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hatırlatmaCheckBox.Location = new System.Drawing.Point(10, 140);
            this.hatırlatmaCheckBox.Name = "hatırlatmaCheckBox";
            this.hatırlatmaCheckBox.Size = new System.Drawing.Size(101, 23);
            this.hatırlatmaCheckBox.TabIndex = 7;
            this.hatırlatmaCheckBox.Text = "Beni Hatırla";
            this.hatırlatmaCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(770, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBuyut
            // 
            this.btnBuyut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.btnBuyut.FlatAppearance.BorderSize = 0;
            this.btnBuyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyut.Location = new System.Drawing.Point(749, -5);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(27, 34);
            this.btnBuyut.TabIndex = 2;
            this.btnBuyut.Text = "□";
            this.btnBuyut.UseVisualStyleBackColor = false;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.Location = new System.Drawing.Point(723, -6);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(31, 36);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "-";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "En az 1 büyük ve 1 küçük harf içermelidir.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.btnBuyut);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.pnlLogin);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOturumAc.ResumeLayout(false);
            this.pnlOturumAc.PerformLayout();
            this.pnlKayitOl.ResumeLayout(false);
            this.pnlKayitOl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSecimKayit;
        private System.Windows.Forms.Button btnSecimOturum;
        private System.Windows.Forms.Panel pnlKayitOl;
        private System.Windows.Forms.Panel pnlOturumAc;
        private System.Windows.Forms.TextBox txtKayitKullanici;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Label şifreKayıt;
        private System.Windows.Forms.Label kullanıcıAdıKayıt;
        private System.Windows.Forms.Label şifrekuralıKayıt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox hatırlatmaCheckBox;
        private System.Windows.Forms.Label kullanıcıAdıOturum;
        private System.Windows.Forms.TextBox txtGirisKullanici;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Label şifreOturum;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBuyut;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Label label2;
    }
}