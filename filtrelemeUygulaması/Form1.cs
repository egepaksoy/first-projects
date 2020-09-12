using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filtrelemeUygulaması
{

    public partial class Form1 : Form
    {
        int a = 0, b = 0, c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void pikselleriArttır()
        {
            
            Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
            int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
            Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
            if (pictureBox2.Image == null)
            {
                girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
            }
            else
            {
                girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
            }
            int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
            int resimYuksekligi = girisResmi.Height;//          ''
            cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
            for(int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
            {
                for(int y = 0; y < resimYuksekligi; y++)
                {
                    okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                    R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                    G = okunanRenk.G;
                    B = okunanRenk.B;

                    donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                    cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
            }
            label2.Text = "Filtrelenmiş Resim";
        }

        public void griTonlama()
        {
            
            if (a == 0)
            {
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
                if (pictureBox2.Image == null)
                {
                    girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                }
                else
                {
                    girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
                }
                int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
                int resimYuksekligi = girisResmi.Height;//          ''
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor
                        int griYap = (okunanRenk.R + okunanRenk.G + okunanRenk.B) / 3;
                        R = griYap;//daha sonra bu değeri rgb değerlerine atıyor
                        G = griYap;
                        B = griYap;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
                label2.Text = "Filtrelenmiş Resim";
                a = 1;
            }
            else
            {
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
                girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
                int resimYuksekligi = girisResmi.Height;//          ''
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor
                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
                label2.Text = "Filtrelenmemiş Resim";
                a = 0;
            }
        }

        public void renkleriDegistir()
        {
            
            if (b == 0)
            {
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
                girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
                int resimYuksekligi = girisResmi.Height;//          ''
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                        if (okunanRenk.R > 100)
                        {
                            R = okunanRenk.B;
                        }
                        else
                        {
                            R = okunanRenk.R;
                        }
                        if (okunanRenk.B > 100)
                        {
                            B = okunanRenk.R;
                        }
                        else
                        {
                            B = okunanRenk.B;
                        }

                        G = okunanRenk.G;//daha sonra bu değeri rgb değerlerine atıyor

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
                label2.Text = "Filtrelenmiş Resim";
            }
            else
            {
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
                girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
                int resimYuksekligi = girisResmi.Height;//          ''
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor
                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
                label2.Text = "Filtrelenmemiş Resim";
                b = 0;
            }
        }
        
        public void kırp(String boyut)
        {
            if (boyut == "1/1")
            {
                Bitmap girisResmi, cikisResmi;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                if (resimGenisligi < resimYuksekligi)
                {
                    resimYuksekligi = pictureBox1.Image.Width;
                }
                if (resimYuksekligi < resimGenisligi)
                {
                    resimGenisligi = pictureBox1.Image.Height;
                }
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                if (pictureBox2.Image == null)
                {
                    girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                }
                else
                {
                    girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
                }
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
            }
            
            
            if (boyut == "4/3")
            {
                Bitmap girisResmi, cikisResmi;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                if (resimGenisligi < resimYuksekligi)
                {
                    resimGenisligi = (pictureBox1.Image.Width / 4 * 3);
                }
                if (resimYuksekligi < resimGenisligi)
                {
                    resimYuksekligi = (pictureBox1.Image.Height / 4 * 3);
                }
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                if (pictureBox2.Image == null)
                {
                    girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                }
                else
                {
                    girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
                }
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
            }
            
            
            if (boyut == "3/2")
            {
                Bitmap girisResmi, cikisResmi;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                if (resimGenisligi < resimYuksekligi)
                {
                    resimGenisligi = (pictureBox1.Image.Width / 3 * 2);
                }
                if (resimYuksekligi < resimGenisligi)
                {
                    resimYuksekligi = (pictureBox1.Image.Height / 3 * 2);
                }
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                if (pictureBox2.Image == null)
                {
                    girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                }
                else
                {
                    girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
                }
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
            }


            if (boyut == "16/9")
            {
                Bitmap girisResmi, cikisResmi;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                if (resimGenisligi < resimYuksekligi)
                {
                    resimGenisligi = (pictureBox1.Image.Width / 16 * 9);
                }
                if (resimYuksekligi < resimGenisligi)
                {
                    resimYuksekligi = (pictureBox1.Image.Height / 16 * 9);
                }
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                if (pictureBox2.Image == null)
                {
                    girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                }
                else
                {
                    girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
                }
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
            }
            label2.Text = "Boyutlandırılmış Resim";
        }

        public void negatif()
        {
            
            if (c == 0)
            {
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
                if (pictureBox2.Image == null)
                {
                    girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                }
                else
                {
                    girisResmi = new Bitmap(pictureBox2.Image);//giriş resmini pictureboxtan alıyor
                }
                int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
                int resimYuksekligi = girisResmi.Height;//          ''
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor

                        R = 255 - okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = 255 - okunanRenk.G;
                        B = 255 - okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
                label2.Text = "Filtrelenmiş Resim";
                c = 1;
            }
            else
            {
                Color okunanRenk, donusenRenk;//resmin renklerini değişkene atıyor
                int R = 0, G = 0, B = 0;//resmin rgb değerlerini veriyor
                Bitmap girisResmi, cikisResmi;//resimleri projeye ekliyor
                girisResmi = new Bitmap(pictureBox1.Image);//giriş resmini pictureboxtan alıyor
                int resimGenisligi = girisResmi.Width;//resmin yükseklik ve genişliğini aynı yapıyor
                int resimYuksekligi = girisResmi.Height;//          ''
                cikisResmi = new Bitmap(resimGenisligi, resimYuksekligi);//çıkış resminin boyutlarını veriyor
                for (int x = 0; x < resimGenisligi; x++)//resmin pixel pixel renk değerlerini okuyor
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        okunanRenk = girisResmi.GetPixel(x, y);//x ve y deki pixeli okunan değere veriyor
                        R = okunanRenk.R;//daha sonra bu değeri rgb değerlerine atıyor
                        G = okunanRenk.G;
                        B = okunanRenk.B;

                        donusenRenk = Color.FromArgb(R, G, B);//donusen rengin rgb renk ayarlarını veriyor 
                        cikisResmi.SetPixel(x, y, donusenRenk);//x ve y kordinatının mevcut rgb ayarlarına veriyor

                    }//değerleri sıfırlayıp döngüyü tekrar başlatıyor
                    pictureBox2.Image = cikisResmi;//resmi pictureboxa yüklüyor
                }
                label2.Text = "Filtrelenmiş Resim";
                c = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void dosyaAc()
        {
            try
            {
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                label1.Text = "Orjinal Resim";
                label2.Text = "";
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        public void dosyaKaydet()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif";
            save.Title = "Filtreli Resim";
            save.ShowDialog();
            if (save.FileName != "")
            {
                FileStream DosyaAkisi = (FileStream)save.OpenFile();
                switch (save.FilterIndex)
                {
                    case 1:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                DosyaAkisi.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pikselleriArttırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pikselleriArttır();
            }
            else
            {
                dosyaAc();
            }
        }

        private void griTonlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                griTonlama();
            }
            else
            {
                dosyaAc();
            }
        }

        private void negatifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                negatif();
            }
            else
            {
                dosyaAc();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc();
            pictureBox2.Image = null;
        }

        private void katdetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                dosyaKaydet();
            }
            else
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Lütfen Önce Bir Dosya Açın", "Kaydedilemez Dosya");
                }
                else
                {
                    MessageBox.Show("Lütfen Önce Bir Filtre Seçin", "Kaydedilemez Dosya");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void renkleriDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                renkleriDegistir();
            }
            else
            {
                dosyaAc();
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = pictureBox1.Image;
                kırp("1/1");
            }
            else
            {
                dosyaAc();
            }
        }

        private void dortBoluUc_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = pictureBox1.Image;
                kırp("4/3");
            }
            else
            {
                dosyaAc();
            }
        }

        private void ucBoluIki_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = pictureBox1.Image;
                kırp("3/2");
            }
            else
            {
                dosyaAc();
            }
        }

        private void onaltiBoluDokuz_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = pictureBox1.Image;
                kırp("16/9");
            }
            else
            {
                dosyaAc();
            }
        }

        private void kırpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
