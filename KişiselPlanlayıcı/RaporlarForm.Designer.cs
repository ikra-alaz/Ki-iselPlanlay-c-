namespace KişiselPlanlayıcı
{
    partial class RaporlarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.lblBasari = new System.Windows.Forms.Label();
            this.pnlHaftalik = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlOzet.SuspendLayout();
            this.pnlHaftalik.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pnlOzet);
            this.panel1.Controls.Add(this.pnlHaftalik);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 597);
            this.panel1.TabIndex = 0;
            // 
            // pnlOzet
            // 
            this.pnlOzet.Controls.Add(this.lblBasari);
            this.pnlOzet.Location = new System.Drawing.Point(500, 66);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(425, 510);
            this.pnlOzet.TabIndex = 2;
            // 
            // lblBasari
            // 
            this.lblBasari.AutoSize = true;
            this.lblBasari.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBasari.Location = new System.Drawing.Point(133, 3);
            this.lblBasari.Name = "lblBasari";
            this.lblBasari.Size = new System.Drawing.Size(159, 28);
            this.lblBasari.TabIndex = 0;
            this.lblBasari.Text = "Başarı Oranı: %0";
            // 
            // pnlHaftalik
            // 
            this.pnlHaftalik.Controls.Add(this.lblToplam);
            this.pnlHaftalik.Location = new System.Drawing.Point(1, 66);
            this.pnlHaftalik.Name = "pnlHaftalik";
            this.pnlHaftalik.Size = new System.Drawing.Size(493, 510);
            this.pnlHaftalik.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblToplam.Location = new System.Drawing.Point(144, 3);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(163, 28);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "Toplam Hedef: 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 65);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelişim Analizi";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKapat.Location = new System.Drawing.Point(933, -2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(20, 24);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(955, 645);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaporlarForm";
            this.Text = "RaporlarForm";
            this.Load += new System.EventHandler(this.RaporlarForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlOzet.ResumeLayout(false);
            this.pnlOzet.PerformLayout();
            this.pnlHaftalik.ResumeLayout(false);
            this.pnlHaftalik.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Panel pnlHaftalik;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblBasari;
    }
}