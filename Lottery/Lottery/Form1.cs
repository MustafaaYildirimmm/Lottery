using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int counter = 0,turSayisi=1;
        int sansliSayi;
        int[] sansliSayilar = new int[6];
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (counter<6)
            {
                sansliSayi = rnd.Next(0, 51);
                if (!sansliSayilar.Contains(sansliSayi))
                {
                    sansliSayilar[counter] = sansliSayi;
                    counter++;
                }
            }

            Array.Sort(sansliSayilar);
            label1.Text = sansliSayilar[0].ToString();
            label2.Text = sansliSayilar[1].ToString();
            label3.Text = sansliSayilar[2].ToString();
            label4.Text = sansliSayilar[3].ToString();
            label5.Text = sansliSayilar[4].ToString();
            label6.Text = sansliSayilar[5].ToString();
            counter = 0;
            turSayisi++;

            if (turSayisi%20==0)
            {
                timer1.Stop();
                foreach (int item in sansliSayilar)
                {
                    lblResult.Text += item + "-";
                }
                lblResult.Text= lblResult.Text.TrimEnd('-');
            }

        }
    }
}
