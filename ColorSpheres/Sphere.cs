using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSpheres
{
    class Sphere
    {
        private Color color;
        private float radius;
        private int qtdThrow;

        public Sphere(Color sphereColor, float sphereRadius)
        {
            color = sphereColor;
            radius = sphereRadius;
            qtdThrow = 0;
        }

        public void Pop() => radius = 0;

        public int GetTimesThrow() => qtdThrow;

        public void Throw()
        {
            if (radius > 0)
                qtdThrow++;
        }
    }
}
