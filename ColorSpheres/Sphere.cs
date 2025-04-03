using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public float GetRadius() => radius;

        public void Throw()
        {
            if (radius > 0)
                qtdThrow++;
        }

        public override string ToString()
        {
            return $"Color:\nR: {color.GetRed()}\nG: {color.GetGreen()}\nB: {color.GetBlue()}\nRadius: {radius}\nTimes throw: {qtdThrow}\n\n";
        }
    }
}
