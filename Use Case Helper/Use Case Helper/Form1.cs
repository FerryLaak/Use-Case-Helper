using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UseCase usecase = null;

        private void PicBoxDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (usecase != null)
            {
                usecase.Draw(g);
            }
        }

        private void PicBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            usecase = new UseCase(e.Location, new Size (200, 100), "Naampje Usecase");

            Refresh();
        }
    }
}
