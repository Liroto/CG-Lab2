using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab2._0
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = pic.CreateGraphics();
            pic.BackColor = Color.FromArgb(65, 105, 225);
        }

        private void pixelsButton_Click(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(200, 200, 200);
            pic.Refresh();
            g.PageUnit = GraphicsUnit.Pixel;
            Pen axesPen = new Pen(Color.Red, 3);
            Pen graphicsPen = new Pen(Color.FromArgb(0, 255, 0), 3);
            g.DrawRectangle(axesPen, 0, 0, pic.Size.Width - 1, pic.Size.Height - 1);
            g.DrawLine(axesPen, 0, (pic.Size.Height - 1) / 2, pic.Size.Width - 1, (pic.Size.Height - 1) / 2);
            g.DrawLine(axesPen, (pic.Size.Width - 1) / 2, 0, (pic.Size.Width - 1) / 2, pic.Size.Height - 1);

            int ex = 0, ey = -300, oldEx = 0, oldEy = 0;
            double x = -Math.PI * 2, y = 0;

            for (ex = 0; ex <= 1000; ex++)
            {
                y = -6 * Math.Pow(x, 2) + 3 * x;
                ey = (pic.Size.Height - 1) - (Convert.ToInt32(y * 200) + 250);
                if (ex != 0) { g.DrawLine(graphicsPen, oldEx, oldEy, ex, ey); }
                oldEx = ex; oldEy = ey;
                x = x + (Math.PI * 4) / (pic.Size.Width - 1);
            }
        }

        private void millimetersButton_Click(object sender, EventArgs e)
        {
            pic.BackColor = Color.FromArgb(200, 200, 200);
            pic.Refresh();
            g.PageUnit = GraphicsUnit.Millimeter;
            Pen axesPen = new Pen(Color.Red, 1f);
            Pen graphicsPen = new Pen(Color.FromArgb(173, 30, 217), 1f);
            int WidthInMM = Convert.ToInt16((pic.Size.Width - 1) / g.DpiX * 25.4);
            int HeightInMM = Convert.ToInt16((pic.Size.Height - 1) / g.DpiY * 25.4);
            g.DrawRectangle(axesPen, 0, 0, WidthInMM, HeightInMM);
            g.DrawLine(axesPen, 0, HeightInMM / 2, WidthInMM, HeightInMM / 2);
            g.DrawLine(axesPen, WidthInMM / 2, 0, WidthInMM / 2, HeightInMM);

            int ex = 0, ey = 0, oldEx = 0, oldEy = 0;
            double current_x = -Math.PI * 2, current_y = 0;

            for (ex = 0; ex <= WidthInMM; ex++)
            {
                current_y = -6 * Math.Pow(current_x, 2) + 3 * current_x;
                ey = HeightInMM - (Convert.ToInt32(current_y * Convert.ToSingle(200 / g.DpiX * 25.4)) + Convert.ToInt32(250 / g.DpiX * 25.4));
                if (ex != 0) { g.DrawLine(graphicsPen, oldEx, oldEy, ex, ey); }
                oldEx = ex; oldEy = ey;
                current_x = current_x + (Math.PI * 4) / WidthInMM;
            }
        }

        private void inchesButton_Click(object sender, EventArgs e)
        {
            
            g.PageUnit = GraphicsUnit.Inch;
            Pen axesPen = new Pen(Color.Red, 0.05f);
            Pen graphicsPen = new Pen(Color.FromArgb(0, 0, 200), 0.05f);
            pic.BackColor = Color.FromArgb(200, 200, 200);
            pic.Refresh();
            float WidthInInches = (pic.Size.Width - 1) / g.DpiX;
            float HeightInInches = (pic.Size.Height - 1) / g.DpiY;
            g.DrawRectangle(axesPen, 0, 0, WidthInInches, HeightInInches);
            g.DrawLine(axesPen, 0, HeightInInches / 2, WidthInInches, HeightInInches / 2);
            g.DrawLine(axesPen, WidthInInches / 2, 0, WidthInInches / 2, HeightInInches);

            
            //Ума не приложу,почему график в дюймах так криво отображается.


            float ey = 0, ex = 0, oldEx = 0, oldEy = 0;
            float current_x = -40, current_y = 0,step = Convert.ToSingle(WidthInInches / 2);

            //while (ex <= WidthInInches + step)
            //{
            //    current_y = Convert.ToSingle(-6 * Math.Pow(current_x, 2)) + 3 * current_x;
            //    ey = Convert.ToSingle(-current_y) + HeightInInches / 2;
            //    if (ex != 0) { g.DrawLine(graphicsPen, oldEx, oldEy, ex, ey); }
            //    oldEx = ex;
            //    oldEy = ey;
            //    ex = ex + step;
            //    current_x = current_x + Convert.ToSingle(Math.PI * 4) / step;
            //}

            while (current_x <= 50)
            {
                current_y = (Convert.ToSingle(-3 * Math.Pow(current_x, 2) + 3 * current_x)) * -4 + -350;
                g.DrawLine(graphicsPen, oldEx, oldEy, current_x, current_y);

                oldEx = current_x;
                oldEy = current_y;

                current_x += 0.1f;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.FromArgb(200, 200, 200));
        }
    }
}
