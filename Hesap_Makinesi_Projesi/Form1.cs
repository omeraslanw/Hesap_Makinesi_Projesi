using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1;
        char islem;
        bool ekraniTemizle; // bool değeri true ya da false olabilecek değişkenler için kullanılır.

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ekraniTemizle == true)
            {
                label1.Text = "";
                ekraniTemizle = false;
            }
            label1.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekraniTemizle = true;
            sayi1 = Convert.ToInt32(label1.Text);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekraniTemizle = true;
            sayi1 = Convert.ToInt32(label1.Text);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekraniTemizle = true;
            sayi1 = Convert.ToInt32(label1.Text);
        }

        private void btnBöl_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekraniTemizle = true;
            sayi1 = Convert.ToInt32(label1.Text);
        }

        private void btnEşit_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToInt32(label1.Text);
            double sonuc;
            switch (islem)
            {
                case '+': sonuc = sayi1 + sayi2; break;
                case '-': sonuc = sayi1 - sayi2; break;
                case '/': sonuc = sayi1 / sayi2; break;
                case '*': sonuc = sayi1 * sayi2; break;
                default: sonuc = 0; break;
            }
            label1.Text = sonuc.ToString();
        }
    }
}
