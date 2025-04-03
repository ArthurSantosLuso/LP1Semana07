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


            Console.WriteLine($"Sphere 1:\nColor:\nR: {esfera1.Color.Red}\nG: {esfera1.Color.Green}\nB: {esfera1.Color.Blue}\n" +
                $"Radius: {esfera1.Radius}\nTimes throw: {esfera1.QtdThrow}\n\n");

            Console.WriteLine($"Sphere 2:\nColor:\nR: {esfera2.Color.Red}\nG: {esfera2.Color.Green}\nB: {esfera2.Color.Blue}\n" +
                $"Radius: {esfera2.Radius}\nTimes throw: {esfera2.QtdThrow}\n\n");

            Console.WriteLine($"Sphere 3:\nColor:\nR: {esfera3.Color.Red}\nG: {esfera3.Color.Green}\nB: {esfera3.Color.Blue}\n" +
                $"Radius: {esfera3.Radius}\nTimes throw: {esfera3.QtdThrow}\n\n");
        }
    }
}
