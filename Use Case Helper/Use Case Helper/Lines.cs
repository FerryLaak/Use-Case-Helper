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
        Point start;
        Point end;

        public Lines(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, start, end);
        }
    }
}
