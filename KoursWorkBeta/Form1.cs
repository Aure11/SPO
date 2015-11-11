using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoursWorkBeta
{
    public partial class Form1 : Form
    {
        Kotel k;
        Datchik d;
        PowerElement pe;
        public Form1()
        {
            InitializeComponent();
            d = new Datchik();
            k = new Kotel();
            pe = new PowerElement();
            
            
        
        }
Point p = new Point();
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.CreateGraphics();
            
            d.DrawBox(e.Graphics);
            k.DrawKotel(e.Graphics);
            pe.DrawBox(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
           
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.toolStripTextBox1.Text))
            {
                int m = Convert.ToInt32(this.toolStripTextBox1.Text);
                if ((m > 0) && (m < 200))
                {

                    k.SetHightWater(m);
                   
                }
                else
                {
                    MessageBox.Show("Water level error", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void нагреватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k.GetMass() > 0)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
                int t = d.GetTemp();
                if ((t < 70) && (t > 0))
                {
                    if ((t > 0) && (t < 30))
                    {
                        pe.SetColor(Color.DarkRed);
                    }
                    else if ((t >= 30) && (t < 35))
                    {
                        pe.SetColor(Color.Red);
                    }
                    else if ((t >= 35) && (t < 50))
                    {
                        pe.SetColor(Color.Orange);
                    }
                    else if ((t >= 50) && (t < 60))
                    {
                        pe.SetColor(Color.Yellow);
                    }
                    d.SetTemp(++t);
                }
                else if ((t > 65) && (t < 70))
                {
                    d.SetTemp(--t);
                }

                Graphics g = CreateGraphics();
                d.DrawBox(g);
                Refresh();
            }
            else { timer1.Stop(); MessageBox.Show("Water level error", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
        }

        private void выключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            k.SetHightWater(50);
            Graphics g = CreateGraphics();
            Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            k.SetHightWater(100);
            Graphics g = CreateGraphics();
            Refresh();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            k.SetHightWater(150);
            Graphics g = CreateGraphics();
            Refresh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            k.SetHightWater(200);
            Graphics g = CreateGraphics();
            Refresh();
        }
        

       
    }
}
