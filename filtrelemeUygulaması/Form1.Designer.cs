namespace filtrelemeUygulaması
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katdetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pikselleriArttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griTonlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkleriDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dortBoluUc = new System.Windows.Forms.ToolStripMenuItem();
            this.ucBoluIki = new System.Windows.Forms.ToolStripMenuItem();
            this.onaltiBoluDokuz = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(13, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(431, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 347);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.katdetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // katdetToolStripMenuItem
            // 
            this.katdetToolStripMenuItem.Name = "katdetToolStripMenuItem";
            this.katdetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.katdetToolStripMenuItem.Text = "Kaydet";
            this.katdetToolStripMenuItem.Click += new System.EventHandler(this.katdetToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrelerToolStripMenuItem,
            this.kırpToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pikselleriArttırToolStripMenuItem,
            this.griTonlamaToolStripMenuItem,
            this.negatifToolStripMenuItem,
            this.renkleriDeğiştirToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // pikselleriArttırToolStripMenuItem
            // 
            this.pikselleriArttırToolStripMenuItem.Name = "pikselleriArttırToolStripMenuItem";
            this.pikselleriArttırToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pikselleriArttırToolStripMenuItem.Text = "Pikselleri Arttır";
            this.pikselleriArttırToolStripMenuItem.Click += new System.EventHandler(this.pikselleriArttırToolStripMenuItem_Click);
            // 
            // griTonlamaToolStripMenuItem
            // 
            this.griTonlamaToolStripMenuItem.Name = "griTonlamaToolStripMenuItem";
            this.griTonlamaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.griTonlamaToolStripMenuItem.Text = "Gri Tonlama";
            this.griTonlamaToolStripMenuItem.Click += new System.EventHandler(this.griTonlamaToolStripMenuItem_Click);
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.negatifToolStripMenuItem.Text = "Negatif";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.negatifToolStripMenuItem_Click);
            // 
            // renkleriDeğiştirToolStripMenuItem
            // 
            this.renkleriDeğiştirToolStripMenuItem.Name = "renkleriDeğiştirToolStripMenuItem";
            this.renkleriDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.renkleriDeğiştirToolStripMenuItem.Text = "Renkleri Değiştir";
            this.renkleriDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkleriDeğiştirToolStripMenuItem_Click);
            // 
            // kırpToolStripMenuItem
            // 
            this.kırpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.dortBoluUc,
            this.ucBoluIki,
            this.onaltiBoluDokuz});
            this.kırpToolStripMenuItem.Name = "kırpToolStripMenuItem";
            this.kırpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.kırpToolStripMenuItem.Text = "Boyutlandır";
            this.kırpToolStripMenuItem.Click += new System.EventHandler(this.kırpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem2.Text = "1/1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dortBoluUc
            // 
            this.dortBoluUc.Name = "dortBoluUc";
            this.dortBoluUc.Size = new System.Drawing.Size(97, 22);
            this.dortBoluUc.Text = "4/3";
            this.dortBoluUc.Click += new System.EventHandler(this.dortBoluUc_Click);
            // 
            // ucBoluIki
            // 
            this.ucBoluIki.Name = "ucBoluIki";
            this.ucBoluIki.Size = new System.Drawing.Size(97, 22);
            this.ucBoluIki.Text = "3/2";
            this.ucBoluIki.Click += new System.EventHandler(this.ucBoluIki_Click);
            // 
            // onaltiBoluDokuz
            // 
            this.onaltiBoluDokuz.Name = "onaltiBoluDokuz";
            this.onaltiBoluDokuz.Size = new System.Drawing.Size(97, 22);
            this.onaltiBoluDokuz.Text = "16/9";
            this.onaltiBoluDokuz.Click += new System.EventHandler(this.onaltiBoluDokuz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(566, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Filter 1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katdetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pikselleriArttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griTonlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem kırpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkleriDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dortBoluUc;
        private System.Windows.Forms.ToolStripMenuItem ucBoluIki;
        private System.Windows.Forms.ToolStripMenuItem onaltiBoluDokuz;
    }
}

