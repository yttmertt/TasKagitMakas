namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oyuncu_secim = new System.Windows.Forms.PictureBox();
            this.bilgisayar_secim = new System.Windows.Forms.PictureBox();
            this.pcb_tas = new System.Windows.Forms.PictureBox();
            this.pcb_kagit = new System.Windows.Forms.PictureBox();
            this.pcb_makas = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKazanan = new System.Windows.Forms.Label();
            this.opuan = new System.Windows.Forms.Label();
            this.bpuan = new System.Windows.Forms.Label();
            this.oskor = new System.Windows.Forms.Label();
            this.bskor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu_secim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayar_secim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_tas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_kagit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_makas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(611, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "BİLGİSAYAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "OYUNCU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyuncu_secim
            // 
            this.oyuncu_secim.BackColor = System.Drawing.Color.Snow;
            this.oyuncu_secim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oyuncu_secim.Location = new System.Drawing.Point(27, 75);
            this.oyuncu_secim.Name = "oyuncu_secim";
            this.oyuncu_secim.Size = new System.Drawing.Size(158, 144);
            this.oyuncu_secim.TabIndex = 34;
            this.oyuncu_secim.TabStop = false;
            // 
            // bilgisayar_secim
            // 
            this.bilgisayar_secim.BackColor = System.Drawing.Color.Snow;
            this.bilgisayar_secim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bilgisayar_secim.Location = new System.Drawing.Point(670, 75);
            this.bilgisayar_secim.Name = "bilgisayar_secim";
            this.bilgisayar_secim.Size = new System.Drawing.Size(158, 144);
            this.bilgisayar_secim.TabIndex = 35;
            this.bilgisayar_secim.TabStop = false;
            // 
            // pcb_tas
            // 
            this.pcb_tas.BackColor = System.Drawing.Color.MistyRose;
            this.pcb_tas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_tas.Image = ((System.Drawing.Image)(resources.GetObject("pcb_tas.Image")));
            this.pcb_tas.Location = new System.Drawing.Point(43, 333);
            this.pcb_tas.Name = "pcb_tas";
            this.pcb_tas.Size = new System.Drawing.Size(95, 80);
            this.pcb_tas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_tas.TabIndex = 36;
            this.pcb_tas.TabStop = false;
            this.pcb_tas.Click += new System.EventHandler(this.pcb_tas_Click);
            // 
            // pcb_kagit
            // 
            this.pcb_kagit.BackColor = System.Drawing.Color.MistyRose;
            this.pcb_kagit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_kagit.Image = ((System.Drawing.Image)(resources.GetObject("pcb_kagit.Image")));
            this.pcb_kagit.Location = new System.Drawing.Point(162, 333);
            this.pcb_kagit.Name = "pcb_kagit";
            this.pcb_kagit.Size = new System.Drawing.Size(95, 80);
            this.pcb_kagit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_kagit.TabIndex = 37;
            this.pcb_kagit.TabStop = false;
            this.pcb_kagit.Click += new System.EventHandler(this.pcb_kagit_Click);
            // 
            // pcb_makas
            // 
            this.pcb_makas.BackColor = System.Drawing.Color.MistyRose;
            this.pcb_makas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcb_makas.Image = ((System.Drawing.Image)(resources.GetObject("pcb_makas.Image")));
            this.pcb_makas.Location = new System.Drawing.Point(281, 333);
            this.pcb_makas.Name = "pcb_makas";
            this.pcb_makas.Size = new System.Drawing.Size(95, 80);
            this.pcb_makas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_makas.TabIndex = 38;
            this.pcb_makas.TabStop = false;
            this.pcb_makas.Click += new System.EventHandler(this.pcb_makas_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label8.Location = new System.Drawing.Point(394, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 44);
            this.label8.TabIndex = 39;
            this.label8.Text = "VS";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(475, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 45);
            this.label3.TabIndex = 40;
            this.label3.Text = "KAZANAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKazanan
            // 
            this.txtKazanan.BackColor = System.Drawing.Color.Salmon;
            this.txtKazanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtKazanan.Location = new System.Drawing.Point(475, 368);
            this.txtKazanan.Name = "txtKazanan";
            this.txtKazanan.Size = new System.Drawing.Size(289, 45);
            this.txtKazanan.TabIndex = 41;
            this.txtKazanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opuan
            // 
            this.opuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.opuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.opuan.Location = new System.Drawing.Point(204, 75);
            this.opuan.Name = "opuan";
            this.opuan.Size = new System.Drawing.Size(147, 23);
            this.opuan.TabIndex = 42;
            this.opuan.Text = "OYUNCU PUANI";
            // 
            // bpuan
            // 
            this.bpuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bpuan.Location = new System.Drawing.Point(479, 75);
            this.bpuan.Name = "bpuan";
            this.bpuan.Size = new System.Drawing.Size(184, 23);
            this.bpuan.TabIndex = 43;
            this.bpuan.Text = "BİLGİSAYAR PUANI";
            // 
            // oskor
            // 
            this.oskor.AutoSize = true;
            this.oskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.oskor.Location = new System.Drawing.Point(277, 111);
            this.oskor.Name = "oskor";
            this.oskor.Size = new System.Drawing.Size(20, 24);
            this.oskor.TabIndex = 44;
            this.oskor.Text = "0";
            // 
            // bskor
            // 
            this.bskor.AutoSize = true;
            this.bskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bskor.Location = new System.Drawing.Point(560, 111);
            this.bskor.Name = "bskor";
            this.bskor.Size = new System.Drawing.Size(20, 24);
            this.bskor.TabIndex = 45;
            this.bskor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 470);
            this.Controls.Add(this.bskor);
            this.Controls.Add(this.oskor);
            this.Controls.Add(this.bpuan);
            this.Controls.Add(this.opuan);
            this.Controls.Add(this.txtKazanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcb_makas);
            this.Controls.Add(this.pcb_kagit);
            this.Controls.Add(this.pcb_tas);
            this.Controls.Add(this.bilgisayar_secim);
            this.Controls.Add(this.oyuncu_secim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taş Kağıt Makas";
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu_secim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayar_secim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_tas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_kagit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_makas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox oyuncu_secim;
        private System.Windows.Forms.PictureBox bilgisayar_secim;
        private System.Windows.Forms.PictureBox pcb_tas;
        private System.Windows.Forms.PictureBox pcb_kagit;
        private System.Windows.Forms.PictureBox pcb_makas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtKazanan;
        private System.Windows.Forms.Label opuan;
        private System.Windows.Forms.Label bpuan;
        private System.Windows.Forms.Label oskor;
        private System.Windows.Forms.Label bskor;
    }
}

