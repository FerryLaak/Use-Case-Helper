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
        public Point location;
        public Image image;

        public Actor(string naam, Point location, Image image)
        {
            this.naam = naam;
            this.location = new Point(location.X, location.Y);
            this.image = image;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(image, location.X, location.Y);
            g.DrawString(naam, new Font(FontFamily.GenericMonospace, 11), Brushes.Black, location.X - 20, location.Y + 150);
        }
    }
}
