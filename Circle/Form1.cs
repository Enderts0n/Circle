using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics g = this.CreateGraphics();
            int count = 5;
            for (int i = 0; i < count; i++)
            {                
                int diameter = rnd.Next(20, 70);
                int x = rnd.Next(0, this.ClientSize.Width - diameter);
                int y = rnd.Next(0, this.ClientSize.Height - diameter);
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                using (Brush yellowBrush = new SolidBrush(randomColor))
                {
                    g.FillEllipse(yellowBrush, x, y, diameter, diameter);
                }                
                using (Pen blackPen = new Pen(Color.Black))
                {
                    g.DrawEllipse(blackPen, x, y, diameter, diameter);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
