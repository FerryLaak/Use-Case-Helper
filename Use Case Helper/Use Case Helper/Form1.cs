using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private List<UseCase> usecases = new List<UseCase>();
        private List<Actor> actors = new List<Actor>();

        private void PicBoxDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                foreach (UseCase uc in usecases)
                {
                    uc.Draw(g);
                }
            
                foreach (Actor ac in actors)
                {
                    ac.Draw(g);
                }
            
        }
        private void PicBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbtnUseCase.Checked == true)
            {
                usecases.Add(new UseCase("Naam usecase", new Size(200, 100), e.Location));
            }
            else if (rdbtnActor.Checked == true)
            {
                actors.Add(new Actor("Naam actor", new Size(100, 100), e.Location));
            }

            Refresh();          
        }
    }
}
