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

        //Fields
        #region
        private List<UseCase> usecases = new List<UseCase>();
        private List<Actor> actors = new List<Actor>();
        private List<Lines> lines = new List<Lines>();
        Point end;
        Point start;
        #endregion

        //Draws all the items in the lists.
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
                foreach (Lines line in lines)
                {
                    line.Draw(g);
                }
            
        }


        //Adds the items to the list and calculates the start point for the line.
        private void PicBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            Image actor = pictureBox1.Image;

            if (rdbtnUseCase.Checked == true)
            {
                usecases.Add(new UseCase(txtbUseCaseInhoud.Text, new Size(200, 100), e.Location));
            }
            if (rdbtnActor.Checked == true && actors.Count < 3)
            {
                actors.Add(new Actor(txtbActor.Text, e.Location, actor));
            }
            if (rdbtnLine.Checked == true)
            {
                start = new Point(e.X, e.Y);
            }

            Refresh();          
        }

       
        //Calculates the point where the mouse is up for the end of the line, adds the line to the list and draws it.
        private void PicBoxDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbtnLine.Checked == true)
            {
                end = new Point(e.X, e.Y);
                lines.Add(new Lines(start, end));
            }
            Refresh();
        }

        
        //Makes the textbox and label visible when necessary.
        private void rdbtnActor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnActor.Checked == true)
            {
                txtbActor.Visible = true;
                lblNaamActor.Visible = true;
            }
            else if (rdbtnActor.Checked == false)
            {
                txtbActor.Visible = false;
                lblNaamActor.Visible = false;
            }
        }
        private void rdbtnUseCase_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnUseCase.Checked == true)
            {
                txtbUseCaseInhoud.Visible = true;
                lblUseCaseInhoud.Visible = true;
            }
            else if (rdbtnUseCase.Checked == false)
            {
                txtbUseCaseInhoud.Visible = false;
                lblUseCaseInhoud.Visible = false;
            }
        }


        //Remove the las item in the list.
        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            if (actors.Count >= 1)
            {
                actors.RemoveAt(actors.Count - 1);
            }
            PicBoxDraw.Refresh();
        }

        private void btnRemoveUseCase_Click(object sender, EventArgs e)
        {
            if (usecases.Count >= 1)
            {
                usecases.RemoveAt(usecases.Count - 1);
            }
            PicBoxDraw.Refresh();
        }

        private void btnRemoveLine_Click(object sender, EventArgs e)
        {
            if (lines.Count >= 1)
            {
                lines.RemoveAt(lines.Count - 1);
            }
            PicBoxDraw.Refresh();
        }


    }
}
