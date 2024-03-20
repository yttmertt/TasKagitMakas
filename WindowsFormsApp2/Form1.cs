using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp2
{
    //timer özelliği ekleme
    //ekrana skor kaça gelince biteceğini gösteren uyarı
    //animasyon 
    //tur sistemi 
    //her turda sonuç ekrana uyarı şeklinde gelsin
    //animasyon ekleme
    //ekranı güzelleştirme
    public partial class Form1 : Form
    {
        int skor1 = 0;
        int skor2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int tas = 1;
            int a = sayiüret();
            if (tas == 1)
            {
                if (a==1)
                {
                    bilgisayar_secim.Image = pictureBox3.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor1++;
                    skor2++;
                    oskor.Text=skor1.ToString();
                    bskor.Text = skor2.ToString();                    
                }
                if (a==2)
                {
                    bilgisayar_secim.Image= pictureBox4.Image;
                    bilgisayar_secim.SizeMode= PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor2++;
                    bskor.Text = skor2.ToString();                
                }
                if (a == 3)
                {
                    bilgisayar_secim.Image = pictureBox5.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor1++;
                    oskor.Text= skor1.ToString();
                }
                oyuncu_secim.Image = pictureBox3.Image;
                oyuncu_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                oyuncu_secim.Visible = true;
                Toplam();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int kagıt = 2;
            int a = sayiüret();
            if(kagıt == 2)
            {
                if (a == 1)
                {
                    bilgisayar_secim.Image = pictureBox3.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor1++;
                    oskor.Text = skor1.ToString();
                }
                if (a == 2)
                {
                    bilgisayar_secim.Image = pictureBox4.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor1++;
                    skor2++;
                    oskor.Text = skor1.ToString();
                    bskor.Text = skor2.ToString();
                }
                if (a == 3)
                {
                    bilgisayar_secim.Image = pictureBox5.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor2++;
                    bskor.Text = skor2.ToString();
                }
                oyuncu_secim.Image = pictureBox4.Image;
                oyuncu_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                oyuncu_secim.Visible=true;
                Toplam();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int makas = 3;
            int a = sayiüret();
            if(makas == 3) 
            {
                if (a == 1)
                {
                    bilgisayar_secim.Image = pictureBox3.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor2++;
                    bskor.Text = skor2.ToString();
                }
                if (a == 2)
                {
                    bilgisayar_secim.Image = pictureBox4.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor1++;
                    oskor.Text = skor1.ToString();
                }
                 if (a == 3)
                {
                    bilgisayar_secim.Image = pictureBox5.Image;
                    bilgisayar_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                    bilgisayar_secim.Visible = true;
                    skor1++;
                    skor2++;
                    oskor.Text = skor1.ToString();
                    bskor.Text = skor2.ToString();
                }
                oyuncu_secim.Image = pictureBox5.Image;
                oyuncu_secim.SizeMode = PictureBoxSizeMode.StretchImage;
                oyuncu_secim.Visible = true;
                Toplam();   
            }
        }

        private int sayiüret()
        {
            Random r = new Random();
            int tkm = r.Next(1, 4);
            return tkm;
        }
        private void Toplam()
        {
            if (skor1 == 10)
            {
                kazanan.Text = "OYUNCU";
                MessageBox.Show("TEBRİKLER OYUNU KAZANDINIZ");
                this.Close();
            }
            else if (skor2 == 10)
            {
                kazanan.Text = "BİLGİSAYAR";
                MessageBox.Show("KAYBETTİNİZ, TEKRAR DENEYİNİZ");
                this.Close();
            } 
        }       
    }
}
