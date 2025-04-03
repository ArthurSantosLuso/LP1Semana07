using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSpheres
{
    class Color
    {
        private readonly byte red, green, blue, alpha;

        // Constructor
        public Color(byte r, byte g, byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        // Overload constructor
        public Color(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
            alpha = 255;
        }

        // Getter methods 
        public byte GetRed() => red;
        public byte GetGreen() => green;
        public byte GetBlue() => blue;
        public byte GetAlpha() => alpha;

        // Get the gray scale of the current color
        public int GerGray() => (red + green + blue) / 3;


    }
}
