using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2012
{
    public partial class Form1 : Form
    {
        private GameLogic gameLogic;

        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 800;
            gameLogic = new GameLogic();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Black, 3);
            Brush brush = new SolidBrush(Color.Black);

            Rectangle rectOut = new Rectangle(200, 80, 600, 600);
            Rectangle rectMid = new Rectangle(300, 180, 400, 400);
            Rectangle rectIn = new Rectangle(400, 280, 200, 200);

            Point p1 = new Point(500, 80);
            Point p2 = new Point(500, 280);

            Point p3 = new Point(200, 380);
            Point p4 = new Point(400, 380);

            Point p5 = new Point(500, 480);
            Point p6 = new Point(500, 680);

            Point p7 = new Point(600, 380);
            Point p8 = new Point(800, 380);

            Rectangle point1 = new Rectangle(194, 74, 13, 13);
            Rectangle point2 = new Rectangle(494, 74, 13, 13);
            Rectangle point3 = new Rectangle(794, 74, 13, 13);

            Rectangle point4 = new Rectangle(294, 174, 13, 13);
            Rectangle point5 = new Rectangle(494, 174, 13, 13);
            Rectangle point6 = new Rectangle(694, 174, 13, 13);

            Rectangle point7 = new Rectangle(394, 274, 13, 13);
            Rectangle point8 = new Rectangle(494, 274, 13, 13);
            Rectangle point9 = new Rectangle(594, 274, 13, 13);

            Rectangle point10 = new Rectangle(194, 374, 13, 13);
            Rectangle point11 = new Rectangle(294, 374, 13, 13);
            Rectangle point12 = new Rectangle(394, 374, 13, 13);
            Rectangle point13 = new Rectangle(594, 374, 13, 13);
            Rectangle point14 = new Rectangle(694, 374, 13, 13);
            Rectangle point15 = new Rectangle(794, 374, 13, 13);

            Rectangle point16 = new Rectangle(394, 474, 13, 13);
            Rectangle point17 = new Rectangle(494, 474, 13, 13);
            Rectangle point18 = new Rectangle(594, 474, 13, 13);

            Rectangle point19 = new Rectangle(294, 574, 13, 13);
            Rectangle point20 = new Rectangle(494, 574, 13, 13);
            Rectangle point21 = new Rectangle(694, 574, 13, 13);

            Rectangle point22 = new Rectangle(194, 674, 13, 13);
            Rectangle point23 = new Rectangle(494, 674, 13, 13);
            Rectangle point24 = new Rectangle(794, 674, 13, 13);

            g.DrawRectangle(pen, rectOut);
            g.DrawRectangle(pen, rectMid);
            g.DrawRectangle(pen, rectIn);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p5, p6);
            g.DrawLine(pen, p7, p8);

            g.DrawEllipse(pen, point1);
            g.DrawEllipse(pen, point2);
            g.DrawEllipse(pen, point3);
            g.DrawEllipse(pen, point4);
            g.DrawEllipse(pen, point5);
            g.DrawEllipse(pen, point6);
            g.DrawEllipse(pen, point7);
            g.DrawEllipse(pen, point8);
            g.DrawEllipse(pen, point9);
            g.DrawEllipse(pen, point10);
            g.DrawEllipse(pen, point11);
            g.DrawEllipse(pen, point12);
            g.DrawEllipse(pen, point13);
            g.DrawEllipse(pen, point14);
            g.DrawEllipse(pen, point15);
            g.DrawEllipse(pen, point16);
            g.DrawEllipse(pen, point17);
            g.DrawEllipse(pen, point18);
            g.DrawEllipse(pen, point19);
            g.DrawEllipse(pen, point20);
            g.DrawEllipse(pen, point21);
            g.DrawEllipse(pen, point22);
            g.DrawEllipse(pen, point23);
            g.DrawEllipse(pen, point24);

            g.FillEllipse(brush, point1);
            g.FillEllipse(brush, point2);
            g.FillEllipse(brush, point3);
            g.FillEllipse(brush, point4);
            g.FillEllipse(brush, point5);
            g.FillEllipse(brush, point6);
            g.FillEllipse(brush, point7);
            g.FillEllipse(brush, point8);
            g.FillEllipse(brush, point9);
            g.FillEllipse(brush, point10);
            g.FillEllipse(brush, point11);
            g.FillEllipse(brush, point12);
            g.FillEllipse(brush, point13);
            g.FillEllipse(brush, point14);
            g.FillEllipse(brush, point15);
            g.FillEllipse(brush, point16);
            g.FillEllipse(brush, point17);
            g.FillEllipse(brush, point18);
            g.FillEllipse(brush, point19);
            g.FillEllipse(brush, point20);
            g.FillEllipse(brush, point21);
            g.FillEllipse(brush, point22);
            g.FillEllipse(brush, point23);
            g.FillEllipse(brush, point24);

            pen.Dispose();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
