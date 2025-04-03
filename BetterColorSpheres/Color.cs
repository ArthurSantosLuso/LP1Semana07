using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    class Color
    {
        private byte Red { get; }
        private byte Green { get; }
        private byte Blue { get; }
        private byte Alpha { get; }
        private byte Gray
        {
            get
            {
                return (byte)((Red + Green + Blue) / 3);
            }
        }

        // Constructor
        public Color(byte r, byte g, byte b, byte a)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = a;
        }

        // Overload constructor
        public Color(byte r, byte g, byte b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
        }
    }
}
