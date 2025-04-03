using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    class Sphere
    {
        public Color Color { get; }
        public float Radius { get; private set; }
        public int QtdThrow { get; private set; }

        public Sphere(Color sphereColor, float sphereRadius)
        {
            Color = sphereColor;
            Radius = sphereRadius;
            QtdThrow = 0;
        }

        public void Pop() => Radius = 0;
        public void Throw()
        {
            if (QtdThrow > 0)
                QtdThrow++;
        }

    }
}
