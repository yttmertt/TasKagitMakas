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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kazanan = new System.Windows.Forms.Label();
            this.opuan = new System.Windows.Forms.Label();
            this.bpuan = new System.Windows.Forms.Label();
            this.oskor = new System.Windows.Forms.Label();
            this.bskor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu_secim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayar_secim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(587, 31);
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
            this.bilgisayar_secim.Location = new System.Drawing.Point(641, 75);
            this.bilgisayar_secim.Name = "bilgisayar_secim";
            this.bilgisayar_secim.Size = new System.Drawing.Size(158, 144);
            this.bilgisayar_secim.TabIndex = 35;
            this.bilgisayar_secim.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(43, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(162, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(281, 288);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label8.Location = new System.Drawing.Point(370, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 39;
            this.label8.Text = "VS";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(462, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 35);
            this.label3.TabIndex = 40;
            this.label3.Text = "KAZANAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kazanan
            // 
            this.kazanan.BackColor = System.Drawing.Color.Salmon;
            this.kazanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.kazanan.Location = new System.Drawing.Point(462, 333);
            this.kazanan.Name = "kazanan";
            this.kazanan.Size = new System.Drawing.Size(289, 35);
            this.kazanan.TabIndex = 41;
            this.kazanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bpuan.Location = new System.Drawing.Point(441, 75);
            this.bpuan.Name = "bpuan";
            this.bpuan.Size = new System.Drawing.Size(184, 23);
            this.bpuan.TabIndex = 43;
            this.bpuan.Text = "BİLGİSAYAR PUANI";
            // 
            // oskor
            // 
            this.oskor.AutoSize = true;
            this.oskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.oskor.Location = new System.Drawing.Point(278, 111);
            this.oskor.Name = "oskor";
            this.oskor.Size = new System.Drawing.Size(20, 24);
            this.oskor.TabIndex = 44;
            this.oskor.Text = "0";
            // 
            // bskor
            // 
            this.bskor.AutoSize = true;
            this.bskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bskor.Location = new System.Drawing.Point(522, 111);
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
            this.ClientSize = new System.Drawing.Size(825, 439);
            this.Controls.Add(this.bskor);
            this.Controls.Add(this.oskor);
            this.Controls.Add(this.bpuan);
            this.Controls.Add(this.opuan);
            this.Controls.Add(this.kazanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox oyuncu_secim;
        private System.Windows.Forms.PictureBox bilgisayar_secim;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kazanan;
        private System.Windows.Forms.Label opuan;
        private System.Windows.Forms.Label bpuan;
        private System.Windows.Forms.Label oskor;
        private System.Windows.Forms.Label bskor;
    }
}

