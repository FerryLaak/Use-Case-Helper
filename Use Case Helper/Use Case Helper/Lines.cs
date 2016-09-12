using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_Helper
{
    class Lines
    {
        //Fields
        Point start;
        Point end;

        //Contructor
        public Lines(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        //Methods
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, start, end);
        }
    }
}
