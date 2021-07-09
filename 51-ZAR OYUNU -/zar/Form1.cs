using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplam1 = 0;
        int toplam2 = 0;
        int sayac1 = 0;
        int sayac2 = 0;       
        void temizle()
        {            
            pb11.Visible = false;
            pb12.Visible = false;
            pb13.Visible = false;
            pb14.Visible = false;
            pb15.Visible = false;
            pb16.Visible = false;            
            pb21.Visible = false;
            pb22.Visible = false;
            pb23.Visible = false;
            pb24.Visible = false;
            pb25.Visible = false;
            pb26.Visible = false;
            pb31.Visible = false;
            pb32.Visible = false;
            pb33.Visible = false;
            pb34.Visible = false;
            pb35.Visible = false;
            pb36.Visible = false;
            pb41.Visible = false;
            pb42.Visible = false;
            pb43.Visible = false;
            pb44.Visible = false;
            pb45.Visible = false;
            pb46.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Enabled = true;
            label1.Text = "...";
            label2.Text = "...";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac1++;
            pb10.Visible = true;
            pb20.Visible = true;
            if (sayac1 == 30)
            {
                timer1.Enabled = false;
                sayac1 = 0;
                int a = rastgele.Next(1, 7);
                label1.Text = a.ToString();
                int b = rastgele.Next(1, 7);
                label2.Text = b.ToString();
                toplam1 = toplam1 + a + b;
                label5.Text = toplam1.ToString();
                if (a == 1)
                {
                    pb11.Visible = true;
                    pb10.Visible = false;
                }
                if (a == 2)
                {
                    pb12.Visible = true;
                    pb10.Visible = false;
                }
                if (a == 3)
                {
                    pb13.Visible = true;
                    pb10.Visible = false;
                }
                if (a == 4)
                {
                    pb14.Visible = true;
                    pb10.Visible = false;
                }
                if (a == 5)
                {
                    pb15.Visible = true;
                    pb10.Visible = false;
                }
                if (a == 6)
                {
                    pb16.Visible = true;
                    pb10.Visible = false;
                }
                if (b == 1)
                {
                    pb21.Visible = true;
                    pb20.Visible = false;
                }
                if (b == 2)
                {
                    pb22.Visible = true;
                    pb20.Visible = false;
                }
                if (b == 3)
                {
                    pb23.Visible = true;
                    pb20.Visible = false;
                }
                if (b == 4)
                {
                    pb24.Visible = true;
                    pb20.Visible = false;
                }
                if (b == 5)
                {
                    pb25.Visible = true;
                    pb20.Visible = false;
                }
                if (b == 6)
                {
                    pb26.Visible = true;                   
                    pb20.Visible = false;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            pb30.Visible = true;
            pb40.Visible = true;
            if (sayac2 == 30)
            {
                timer2.Enabled = false;
                sayac2 = 0;
                int c = rastgele.Next(1, 7);
                label4.Text = c.ToString();
                int d = rastgele.Next(1, 7);
                label3.Text = d.ToString();
                toplam2 = toplam2 + c + d;
                label6.Text = toplam2.ToString();
                if (d == 1)
                {
                    pb31.Visible = true;
                    pb30.Visible = false;
                }
                if (d == 2)
                {
                    pb32.Visible = true;
                    pb30.Visible = false;
                }
                if (d == 3)
                {
                    pb33.Visible = true;
                    pb30.Visible = false;
                }
                if (d == 4)
                {
                    pb34.Visible = true;
                    pb30.Visible = false;
                }
                if (d == 5)
                {
                    pb35.Visible = true;
                    pb30.Visible = false;
                }
                if (d == 6)
                {
                    pb36.Visible = true;
                    pb30.Visible = false;
                }
                if (c == 1)
                {
                    pb41.Visible = true;
                    pb40.Visible = false;
                }
                if (c == 2)
                {
                    pb42.Visible = true;
                    pb40.Visible = false;
                }
                if (c == 3)
                {
                    pb43.Visible = true;
                    pb40.Visible = false;
                }
                if (c == 4)
                {
                    pb44.Visible = true;
                    pb40.Visible = false;
                }
                if (c == 5)
                {
                    pb45.Visible = true;
                    pb40.Visible = false;
                }
                if (c == 6)
                {
                    pb46.Visible = true;
                    pb40.Visible = false;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
            button2.Enabled = false;
            button1.Enabled = true;
            timer2.Enabled = true;
            label3.Text = "...";
            label4.Text = "...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
