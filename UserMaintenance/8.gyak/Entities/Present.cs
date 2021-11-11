using _8.gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gyak.Entities
{
    public class Present : Toy
    {
        public SolidBrush boxColor { get; set; }
        public SolidBrush ribbonColor { get; set; }

        public Present(Color box, Color ribbon)
        {
            boxColor = new SolidBrush(box);
            ribbonColor = new SolidBrush(ribbon);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(boxColor, 0, 0, 70, 70);
            g.FillRectangle(ribbonColor, 20, 0, 10, 70);
            g.FillRectangle(ribbonColor, 0, 20, 70, 10);
        }
    }
}
