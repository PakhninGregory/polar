using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polar
{
    public partial class Form1 : Form
    {
        private int xMin = -10;
        private int xMax = 10;
        private int yMin = -10;
        private int yMax = 10;

        private int dx, dy;
        private int x0, y0;

        private int x1, x2, y1, y2;

        private void textBoxXmax_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxXmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int arrowSize = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxXmin.Text, out xMin)) MessageBox.Show("Некорректное значение X min");
            if (!int.TryParse(textBoxXmax.Text, out xMax)) MessageBox.Show("Некорректное значение X max");
            if (!int.TryParse(textBoxYmin.Text, out yMin)) MessageBox.Show("Некорректное значение Y min");
            if (!int.TryParse(textBoxYmax.Text, out yMax)) MessageBox.Show("Некорректное значение Y max");
            panel2.Refresh();
        }


        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dx = panel2.Width / (xMax - xMin);
            dy = panel2.Height / (yMax - yMin);
            x0 = -dx * xMin;
            y0 = dy * yMax;

            for (int x = xMin; x <= xMax; x++)
                e.Graphics.DrawLine(Pens.LightGray, x0 + x * dx, 0, x0 + x * dx, panel2.Height);
            

            for (int y = yMin; y <= yMax; y++)
                e.Graphics.DrawLine(Pens.LightGray, 0, y0 - y * dy, panel2.Width, y0 - y * dy);

            double xp, yp, F, r, pi, p, sh;
            int o;

            o = 2;
            pi = 3.1415926535;
            r = 0;

            double x11, x12 = 0, y11, y12 = 0;

            sh = (o * pi) / (o * 180);

            for (int i = 0; i < o * 180; i++)
            {
                r += sh;
                F = i;

                xp = r * Math.Cos(F * Math.PI / 180);
                yp = r * Math.Sin(F * Math.PI / 180);

                x11 = x12;
                y11 = y12;
                x12 = xp;
                y12 = yp;

                e.Graphics.DrawLine(Pens.Purple, (float)(x0 + x11 * dx), (float)(y0 - y11 * dy), (float)(x0 + x12 * dx), (float)(y0 - y12 * dy));
            }


            F = double.Parse(textBox5.Text);
            r = double.Parse(textBox6.Text);
            xp = r * Math.Cos(F * Math.PI / 180);
            yp = r * Math.Sin(F * Math.PI / 180);

            e.Graphics.DrawLine(Pens.Black, 0, y0, panel2.Width, y0);
            e.Graphics.DrawLine(Pens.Black, x0, 0, x0, panel2.Height);

            e.Graphics.FillPolygon(Brushes.Black, new PointF[] { new PointF(panel2.Width, y0), new PointF(panel2.Width - arrowSize, y0 - arrowSize), new PointF(panel2.Width - arrowSize, y0 + arrowSize) });
            e.Graphics.FillPolygon(Brushes.Black, new PointF[] { new PointF(x0, 0), new PointF(x0 - arrowSize, arrowSize), new PointF(x0 + arrowSize, arrowSize) });

            Font f = new Font("Arial", 12);
            e.Graphics.DrawString("Y", f, Brushes.Black, x0 + 10, 0);
            e.Graphics.DrawString("X", f, Brushes.Black, panel2.Width - 25, y0 + 10);
        }
    }
}
