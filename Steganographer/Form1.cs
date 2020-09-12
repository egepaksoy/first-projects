using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Steganographer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ac()
        {
            openFileDialog1.Filter = "Resim Dosyaları(*.png *.gif)|*.png;*.gif|All Files(*.*)|*.*";
            openFileDialog1.DefaultExt = "resim";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        public void kaydet()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png Resmi|*.png|Gif Resmi|*.gif";
            save.DefaultExt = "resimout";

            if (save.ShowDialog() == DialogResult.OK) //Dosya adı boş değilse kaydedecek.
            {
                // FileStream nesnesi ile kayıtı gerçekleştirecek.
                FileStream DosyaAkisi = (FileStream)save.OpenFile();
                switch (save.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pictureBox1.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pictureBox1.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        pictureBox1.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Png);
                        break;

                }
                DosyaAkisi.Close();
            }

        }

        public void gizle()
        {
            Bitmap img = new Bitmap(pictureBox1.Image) , resim2;
            Color okunanRenk, rgb;
            int r, g, b;
            String mesaj = textBox1.Text;
            int a = 0;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y= 0; y < img.Height; y++)
                {
                    okunanRenk = img.GetPixel(x, y);
                    if (x < 1 && y < textBox1.TextLength)
                    {
                        Char harfler = Convert.ToChar(textBox1.Text.Substring(y, 1));
                        int deger = Convert.ToInt32(harfler);

                        r = okunanRenk.R;
                        g = okunanRenk.G;
                        b = deger;

                        rgb = Color.FromArgb(r, g, b);
                        img.SetPixel(x, y, rgb);
                        if (a == 0)
                        {
                            if (MessageBox.Show("B nin pixel değeri: " + b + "\n devamını görmek istermisin", "Değer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                a = 1;
                            }
                            else
                            {
                                a = 2;
                            }
                        }
                        if (a == 1)
                        {
                            MessageBox.Show(textBox2.Text.Substring(y, 1) + "'nin pixel deği: " + b, "Değer");
                        }

                    }
                    else
                    {
                        r = okunanRenk.R;
                        g = okunanRenk.G;
                        b = okunanRenk.B;

                        rgb = Color.FromArgb(r, g, b);
                        img.SetPixel(x, y, rgb);
                    }
                    if (x == img.Width -1 && y == img.Height - 1)
                    {
                        img.SetPixel(x, y, Color.FromArgb(okunanRenk.R, textBox2.TextLength, textBox1.TextLength));
                    }
                }
                pictureBox1.Image = img;
            }
            decode(img);
            kaydet();
            MessageBox.Show("Metniniz başarıyla resme aktarıldı", "Başarılı");

        }

        public void cikart()
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            String yazı = "";
            int R, G, B;
            Color pixel;
            Color sonPixel = resim.GetPixel(resim.Width - 1, resim.Height - 1);
            int yazıUzunlugu = sonPixel.B;

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    pixel = resim.GetPixel(x, y);

                    if (x < 1 && y < yazıUzunlugu)
                    {
                        int deger = pixel.B;
                        if (deger < 126)
                        {

                            char harf = Convert.ToChar(deger);
                            string karakter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(harf) });

                            yazı += karakter;
                        }
                    }
                }
            }
            
            if (textBox2.Text == encode())
            {
                textBox1.Text = yazı;
                MessageBox.Show("Metniniz başarıyla resimden çıkartıldı", "Başarılı");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifre boş olmamalıdır", "Parola Hatası");
            }
            else
            {
                MessageBox.Show("Yanlış şifre", "Parola Hatası");
            }
            MessageBox.Show(encode());


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }













        public void decode(Bitmap img)
        {
            int kontrol;
            Color okunanRenk;
            int r, g, b;
            for (int x =0; x < img.Width;x++)
            {
                for (int y = 0; y < textBox2.TextLength; y++)
                { 
                    okunanRenk = img.GetPixel(x, y);
                    if (x == 3 && y < textBox2.TextLength)
                    {
                        Color kontrolRenk = img.GetPixel(0,0);
                        if (img.GetPixel(0,0).R == 1)
                        {
                            kontrol = 0;
                            r = kontrol;
                            g = kontrolRenk.G;
                            b = kontrolRenk.B;
                            img.SetPixel(0, 0, Color.FromArgb(r, g, b));
                        }
                        
                        if (img.GetPixel(0, 0).R == 0)
                        {
                            kontrol = 1;
                            r = kontrol;
                            g = kontrolRenk.G;
                            b = kontrolRenk.B;
                            img.SetPixel(0, 0, Color.FromArgb(r, g, b));
                        }
                        
                        Char harfler = Convert.ToChar(textBox2.Text.Substring(y, 1));
                        int deger = Convert.ToInt32(harfler);

                        r = okunanRenk.R;
                        g = deger;
                        b = okunanRenk.B;
                        img.SetPixel(x, y, Color.FromArgb(r, g, b));

                    }

                    

                }
            }
            pictureBox1.Image = img;
        }


        public string encode()
        {
            Color okunanRenk;
            Bitmap img = new Bitmap(pictureBox1.Image);
            String sifre = "";
            int sifreUzunlugu = img.GetPixel(img.Width - 1, img.Height - 1).G;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    okunanRenk = img.GetPixel(x, y);
                    if (x == 3 && y < sifreUzunlugu)
                    {
                        int deger = okunanRenk.G;

                        char harf = Convert.ToChar(deger);

                        string karakter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(harf) });

                        sifre += karakter;
                    }
                }
            }
            return sifre;
        }










        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gizle();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cikart();
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ac();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Gizle";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void çıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Çıkart";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Önce Bir Resim Açılamlıdır", "Hata");
                ac();
            }
            else
            {
                if(button1.Text == "")
                {
                    MessageBox.Show("İşlemi seçin");
                }

                if (button1.Text == "Gizle")
                {
                    gizle();
                    textBox1.Text = "";
                }
                if (button1.Text == "Çıkart")
                {
                    cikart();
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
