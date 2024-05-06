using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2012
{
    public partial class Form1 : Form
    {
        private PictureBox selectedStone = null;
        private bool gameStarted = false;

        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 800;
        }

        private void InitializePlayerStones()
        {
            const int stoneWidth = 50;
            const int stoneHeight = 50;
            const int spaceBetweenStones = 10;
            const int startXLeft = 50;
            const int startXRight = 900;
            const int startY = 100;

            // Create black stones on the left side
            for (int i = 0; i < 9; i++)
            {
                PictureBox LeftStone = new PictureBox();
                LeftStone.Image = Properties.Resources.left_stone;
                LeftStone.SizeMode = PictureBoxSizeMode.StretchImage;
                LeftStone.Size = new Size(stoneWidth, stoneHeight);
                LeftStone.Location = new Point(startXLeft, startY + (stoneHeight + spaceBetweenStones) * i);
                LeftStone.Click += new EventHandler(Stone_Click);
                Controls.Add(LeftStone);
            }

            // Create white stones on the right side
            for (int i = 0; i < 9; i++)
            {
                PictureBox RightStone = new PictureBox();
                RightStone.Image = Properties.Resources.right_stone;
                RightStone.SizeMode = PictureBoxSizeMode.StretchImage;
                RightStone.Size = new Size(stoneWidth, stoneHeight);
                RightStone.Location = new Point(startXRight, startY + (stoneHeight + spaceBetweenStones) * i);
                RightStone.Click += new EventHandler(Stone_Click);
                Controls.Add(RightStone);
            }
        }

        private void Stone_Click(object sender, EventArgs e)
        {
            PictureBox stone = sender as PictureBox;
            if (stone != null)
            {
                if (selectedStone == stone)
                {
                    // Deselect the stone if it's already selected
                    selectedStone = null;
                    return;
                }

                if (selectedStone == null)
                {
                    // Select the stone if no stone is selected
                    selectedStone = stone;
                    return;
                }

                // Handle placing the stone on the game board or any other custom logic here
                // This logic depends on the game rules and requirements

                // For example, you can place the stone at the clicked location
                Point clickLocation = this.PointToClient(Cursor.Position);
                selectedStone.Location = new Point(clickLocation.X - stone.Width / 2, clickLocation.Y - stone.Height / 2);

                // Deselect the stone after placing it
                selectedStone = null;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                InitializePlayerStones();
                DrawBoard();
                gameStarted = true;
            }
        }

        private void DrawBoard()
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);

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

            g.DrawRectangle(pen, rectOut);
            g.DrawRectangle(pen, rectMid);
            g.DrawRectangle(pen, rectIn);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p5, p6);
            g.DrawLine(pen, p7, p8);

            DrawPoints(g);

            pen.Dispose();
        }

        private void DrawPoints(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Rectangle[] points = new Rectangle[]
            {
                new Rectangle(194, 74, 13, 13), new Rectangle(494, 74, 13, 13), new Rectangle(794, 74, 13, 13),
                new Rectangle(294, 174, 13, 13), new Rectangle(494, 174, 13, 13), new Rectangle(694, 174, 13, 13),
                new Rectangle(394, 274, 13, 13), new Rectangle(494, 274, 13, 13), new Rectangle(594, 274, 13, 13),
                new Rectangle(194, 374, 13, 13), new Rectangle(294, 374, 13, 13), new Rectangle(394, 374, 13, 13),
                new Rectangle(594, 374, 13, 13), new Rectangle(694, 374, 13, 13), new Rectangle(794, 374, 13, 13),
                new Rectangle(394, 474, 13, 13), new Rectangle(494, 474, 13, 13), new Rectangle(594, 474, 13, 13),
                new Rectangle(294, 574, 13, 13), new Rectangle(494, 574, 13, 13), new Rectangle(694, 574, 13, 13),
                new Rectangle(194, 674, 13, 13), new Rectangle(494, 674, 13, 13), new Rectangle(794, 674, 13, 13)
            };

            foreach (Rectangle point in points)
            {
                g.DrawEllipse(Pens.Black, point);
                g.FillEllipse(brush, point);
            }

            brush.Dispose();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
