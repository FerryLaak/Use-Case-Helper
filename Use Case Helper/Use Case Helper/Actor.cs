using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Use_Case_Helper
{
    class Actor
    {
        public string naam;
        public Size size;
        public Point location;

        public Actor(string naam, Size size, Point location)
        {
            this.naam = naam;
            this.size = size;
            this.location = new Point(location.X - (size.Width / 2), location.Y - (size.Height / 2));
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, location.X, location.Y, size.Width, size.Height);
            g.DrawString(naam, new Font(FontFamily.GenericMonospace, 11), Brushes.Black, location.X, location.Y);
        }
    }
}
