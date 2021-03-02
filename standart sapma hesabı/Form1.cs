using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace standart_sapma_hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStandarts_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double sayi = Convert.ToDouble(txtSayigir.Text);
            double[] dizi = new double[Convert.ToInt32(txtSayigir.Text)];
            for (int i = 0; i < sayi; i++)
            {
                dizi[i] = rnd.Next(1, 50);
                listBox1.Items.Add(dizi[i]);
            }
            txtRecursive.Text = std(dizi,dizi.Length).ToString();
            txtIteratif.Text = Iteratif(dizi).ToString();
            
        }
        private double std(double[] dizi, int n)
        {
            double toplam= Recursive(dizi, 0, n);
            return Math.Sqrt(toplam/(dizi.Length-1));
        }
        private double Recursive(double[] dizi,int i,int n)
        {
            double ortalama= Ortalama(dizi);
            if (i<dizi.Length)
            {
                return Math.Pow((dizi[i]-ortalama),2)+Recursive(dizi,i+1,n);
            }
            return 0;
        }

        private double Ortalama(double[] dizi)
        {
            double toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += dizi[i];
            }
            return toplam / dizi.Length;
        }

        private double Iteratif(double[] dizi)
        {
            double toplam=0,ortalama=0;
            ortalama = Ortalama(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += Math.Pow(dizi[i]-ortalama,2);
            }
            return Math.Sqrt(toplam/(dizi.Length-1));
        }
    }
}
