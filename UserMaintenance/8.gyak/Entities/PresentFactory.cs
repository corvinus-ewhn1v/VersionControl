using _8.gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gyak.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color boxColor { get; set; }
        public Color ribbonColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(boxColor, ribbonColor);
        }
    }
}
