using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper
{
    class UseCase
    {
        //Fields
        public string naam;
        public Size size;
        public Point location;

        //Constructor
        public UseCase(string naam, Size size, Point location)
        {
            this.naam = naam;
            this.size = size;
            this.location = new Point(location.X - (size.Width /2), location.Y - (size.Height /2));
        }

        //Methods
        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, location.X, location.Y, size.Width, size.Height);
            g.DrawString(naam, new Font(FontFamily.GenericMonospace, 11), Brushes.Black, location.X + 20 , location.Y + 20);
        }

    }
}
