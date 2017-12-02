using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureProj
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DrawText();
        }

        private void dawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawText();
        }

        void DrawText()
        {
            var width = pictureBox1.Width;
            var height = pictureBox1.Height;
            var radius = 15;
            var point = new PointF(rnd.Next(0, width), rnd.Next(0, height));
            var circleRect = new Rectangle(rnd.Next(0, width), rnd.Next(0, height), radius, radius);
            var font = new Font("Arial", 25);
            var brush = Brushes.Black;
            var pen = new Pen(brush, radius);
            using (var gr = pictureBox1.CreateGraphics())
            {
                gr.Clear(pictureBox1.BackColor);
                gr.DrawString("System.String", font, brush, point);
                gr.DrawEllipse(pen, circleRect);
                //gr.DrawLine(pen, new PointF(5, 10), new PointF(10, 100));
            }
        }
    }
}
