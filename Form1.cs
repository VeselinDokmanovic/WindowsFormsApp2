using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b_tenk.Location.X-5> p_zaIgru.Location.X)
            {
                b_tenk.Location = new Point(b_tenk.Location.X - 5, b_tenk.Location.Y);


            }
            else
            {
                MessageBox.Show("Ne moze dalje");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int formY = p_zaIgru.Height;
            formY -= b_tenk.Height;
            int formX = p_zaIgru.Width;
            formX -= b_tenk.Width;
            b_tenk.Location = new Point(formX / 2, formY);
            int trenutnavrednostpoena;

            Random rnd = new Random();
            int randomV = rnd.Next(10,40);
            int randomS = rnd.Next(10,40);
            b_meta.Size = new Size(randomS, randomV);
            int randomX = rnd.Next(p_zaIgru.Height);
            int randomY = rnd.Next(p_zaIgru.Width - 350);
            b_meta.Location = new Point(randomX, randomY);
            if (randomS < 20)
            {
                trenutnavrednostpoena = 3;
            }
            else if (randomS < 30)
            {
                trenutnavrednostpoena = 2;
            }
            else
            {
                trenutnavrednostpoena = 1;
            }
            int priv = Convert.ToInt32(b_tenk.Location.Y);
            priv -= Convert.ToInt32(b_meta.Location.Y);
            priv /= 100;
            if (priv == 0)
                priv = 1;
            priv += trenutnavrednostpoena;
            b_meta.Text = Convert.ToString(priv);
            lbl_sledeciPogodak.Text = Convert.ToString(priv);
        }

        private void p_zaIgru_Resize(object sender, EventArgs e)
        {
            int formY = p_zaIgru.Height;
            formY -= b_tenk.Height;
            int formX = p_zaIgru.Width;
            formX -= b_tenk.Width;
            b_tenk.Location = new Point(formX / 2, formY);
            int trenutnavrednostpoena;

            Random rnd = new Random();
            int randomV = rnd.Next(10,40);
            int randomS = rnd.Next(10,40);
            b_meta.Size = new Size(randomS, randomV);
            int randomX = rnd.Next(p_zaIgru.Height);
            int randomY = rnd.Next(p_zaIgru.Width - 350);
            b_meta.Location = new Point(randomX, randomY);
            if (randomS < 20)
            {
                trenutnavrednostpoena = 3;
            }
            else if (randomS < 30)
            {
                trenutnavrednostpoena = 2;
            }
            else
            {
                trenutnavrednostpoena = 1;
            }
            int priv = Convert.ToInt32(b_tenk.Location.Y);
            priv -= Convert.ToInt32(b_meta.Location.Y);
            priv /= 100;
            if (priv == 0)
                priv = 1;
            priv += trenutnavrednostpoena;
            b_meta.Text = Convert.ToString(priv);
            lbl_sledeciPogodak.Text = Convert.ToString(priv);
        }

        private void b_desno_Click(object sender, EventArgs e)
        {
            if (b_tenk.Location.X + 5 < p_zaIgru.Width - b_tenk.Width)
            {
                b_tenk.Location = new Point(b_tenk.Location.X + 5, b_tenk.Location.Y);


            }
            else
            {
                MessageBox.Show("Ne moze dalje");
            }
        }

        private void b_pucaj_Click(object sender, EventArgs e)
        {
            Button metak = new Button();
            metak.Height = 5;
            metak.Width = 5;
            metak.BackColor = Color.Red;
            metak.ForeColor = Color.Red;
            int metakX = b_tenk.Location.X + (b_tenk.Width / 2) - (metak.Width / 2);
            int metakY = b_tenk.Location.Y;
            metak.Location = new Point(b_tenk.Location.X + (b_tenk.Width/2) - (metak.Width/2), b_tenk.Location.Y);
            p_zaIgru.Controls.Add(metak);
            bool pogodjen = false;
            while (metak.Location.Y > p_zaIgru.Location.Y)
            {
                metakY -= 5;
                metak.Location = new Point(metakX,metakY);
                metak.Refresh();
                Thread.Sleep(14);
                if ((metak.Location.X > b_meta.Location.X && metak.Location.X< b_meta.Location.X + b_meta.Width) && (metak.Location.Y > b_meta.Location.Y && metak.Location.Y < b_meta.Location.Y + b_meta.Height))
                {
                    pogodjen = true;
                    int privremeni = Convert.ToInt32(lbl_brojPoena.Text);
                    privremeni += Convert.ToInt32(b_meta.Text);
                    lbl_brojPoena.Text = Convert.ToString(privremeni);
                    p_zaIgru.BackColor = Color.Green;
                    break;
                }
            }
            if(!pogodjen)
            {
                b_meta.BackColor = Color.Blue;
                b_tenk.BackColor = Color.Red;
            }
            else
            {
                p_zaIgru.Controls.Remove(metak);
                Thread.Sleep(500);
                p_zaIgru.BackColor = Color.Black;
                NapraviNovuMetu();
            }

        }
        private void NapraviNovuMetu()
        {
            Random rnd = new Random();
            int randomV = rnd.Next(10,40);
            int randomS = rnd.Next(10,40);
            b_meta.Size = new Size(randomS, randomV);
            int randomX = rnd.Next(p_zaIgru.Height);
            int randomY = rnd.Next(p_zaIgru.Width - 350);
            b_meta.Location = new Point(randomX, randomY);
            int trenutnavrednostpoena;
            if (randomS < 20)
            {
                trenutnavrednostpoena = 3;
            }
            else if (randomS < 30)
            {
                trenutnavrednostpoena = 2;
            }
            else
            {
                trenutnavrednostpoena = 1;
            }
            int priv = Convert.ToInt32(b_tenk.Location.Y);
            priv -= Convert.ToInt32(b_meta.Location.Y);
            priv /= 100;
            if (priv == 0)
                priv = 1;
            priv += trenutnavrednostpoena;
            b_meta.Text = Convert.ToString(priv);
            lbl_sledeciPogodak.Text = Convert.ToString(priv);
        }

    }
}
