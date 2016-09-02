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
        private string name;
        private Point location;
        private Size size;

        

        public UseCase(Point location, Size size, string name)
        {
            this.name = name;
            this.size = size;
            this.location = new Point(location.X - (size.Width /2), location.Y - (size.Height /2));
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, location.X, location.Y, size.Width, size.Height);
            g.DrawString(name, new Font(FontFamily.GenericMonospace, 11), Brushes.Black, location);
                
        }
    }
}
