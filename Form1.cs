using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_transformation
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Height , pictureBox1.Size.Width);
            pictureBox1.Image = DrawArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X1 = 60, Y1 = 40, X2 = 250, Y2 = 100;
            int x = 30, y = 30;
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Red,4);
            Pen mypen2 = new Pen(Color.Black,4);

            g.DrawLine(mypen, X1, Y1, X2, Y2);
            X1 = X1 + x;
            Y1 = Y1 + y;
            X2 = X2 + x;
            Y2 = Y2 + y;
            g.DrawLine(mypen2, X1, Y1, X2, Y2);
            pictureBox1.Image = DrawArea;

            g.Dispose();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int  x = 70, y = 80, xn, yn;
            int X1 = 200, Y1 = 100, X2 = 300, Y2 = 250;
            double r11, r12, r21, r22, angle = 50;

            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.Red, 4);
            Pen mypen2 = new Pen(Color.Black, 4);
            g.DrawLine(mypen, X1, Y1, X2, Y2);

            r11 = Math.Cos((angle * 3.1428) / 180);
            r12 = Math.Sin((angle * 3.1428) / 180);
            r21 = (-Math.Sin((angle * 3.1428) / 180));
            r22 = Math.Cos((angle * 3.1428) / 180);

            xn = ((int)((x * r11) - (y * r12)));
            yn = ((int)((x * r12) + (y * r11)));

            g.DrawLine(mypen2, X1, Y1, xn, yn);
            pictureBox1.Image = DrawArea;




        }


        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            int X1 = 250, Y1 = 150, X2 = 350, Y2 = 300;
            int x = 100;
            int y = 150;

            Pen mypen = new Pen(Color.Black, 4);
            Pen mypen2 = new Pen(Color.Red, 4);

            g.DrawLine(mypen, x, y, X1, Y1);
            g.DrawLine(mypen, X1, Y1, X2, Y2);
            g.DrawLine(mypen, X2, Y2, x, y);

            pictureBox1.Image = DrawArea;
            int dx = 2;
            int dy = 3;

            x = x * dx;
            X1 = X1 * dx;
            X2 = X2 * dx;
            y = y * dy;
            Y1 = Y1 * dy;
            Y2 = Y2 * dy;
            g.DrawLine(mypen2, x, y, X1, Y1);
            g.DrawLine(mypen2, X1, Y1, X2, Y2);
            g.DrawLine(mypen2, X2, Y2, x, y);

            pictureBox1.Image = DrawArea;
            g.Dispose();
        }
        
            
    }
}
