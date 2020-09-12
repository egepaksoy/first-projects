using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinası
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            
        }

        private void cikarma_Click(object sender, EventArgs e)
        {

        }

        private void carpma_Click(object sender, EventArgs e)
        {

        }

        private void bolme_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void Rakamlar(object sender, EventArgs e)
        {
            if (TxtSonuc.Text == "0" || optDurum)
                TxtSonuc.Clear();
            optDurum = false;
            Button btn = (Button)sender;
            TxtSonuc.Text += btn.Text;

        }

        private void Islemler(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            LabelSonuc.Text = LabelSonuc.Text + " " + TxtSonuc.Text + " " + yeniOpt;

            switch (opt)
            {
                case "+":TxtSonuc.Text = (sonuc + Double.Parse(TxtSonuc.Text)).ToString();
                    break;
                case "-":
                    TxtSonuc.Text = (sonuc - Double.Parse(TxtSonuc.Text)).ToString();
                    break;
                case "*":
                    TxtSonuc.Text = (sonuc * Double.Parse(TxtSonuc.Text)).ToString();
                    break;
                case "/":
                    TxtSonuc.Text = (sonuc / Double.Parse(TxtSonuc.Text)).ToString();
                    break;

            }
            sonuc = Double.Parse(TxtSonuc.Text);
            TxtSonuc.Text = sonuc.ToString();

            opt = yeniOpt;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtSonuc.Text = "0";
            LabelSonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LabelSonuc.Text = "";
            optDurum = true;

            switch (opt)
            {
                case "+":
                    TxtSonuc.Text = (sonuc + Double.Parse(TxtSonuc.Text)).ToString();
                    break;
                case "-":
                    TxtSonuc.Text = (sonuc - Double.Parse(TxtSonuc.Text)).ToString();
                    break;
                case "*":
                    TxtSonuc.Text = (sonuc * Double.Parse(TxtSonuc.Text)).ToString();
                    break;
                case "/":
                    TxtSonuc.Text = (sonuc / Double.Parse(TxtSonuc.Text)).ToString();
                    break;

            }
            sonuc = Double.Parse(TxtSonuc.Text);
            TxtSonuc.Text = sonuc.ToString();

            opt = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(TxtSonuc.Text == "0")
            {
                TxtSonuc.Text = "0";
            }

            else if (optDurum)
            {
                TxtSonuc.Text = "0";
            }

            if (!TxtSonuc.Text.Contains(","))
            {
                TxtSonuc.Text +=",";
            }
            optDurum = false;
                    
        }
    }
}
