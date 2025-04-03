using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Sphere esfera1 = new Sphere(new Color(255, 255, 255), 5);
            Sphere esfera2 = new Sphere(new Color(0, 255, 255), 2);
            Sphere esfera3 = new Sphere(new Color(255, 0, 0), 1);

            esfera1.Throw();
            esfera1.Throw();
            esfera1.Throw();

            esfera2.Throw();
            esfera2.Throw();

            esfera3.Throw();
            esfera3.Pop();
            esfera3.Throw();



            Console.WriteLine($"Sphere 1:\n{esfera1}");
            Console.WriteLine($"Sphere 2:\n{esfera2}");
            Console.WriteLine($"Sphere 3:\n{esfera3}");
        }
    }
}
