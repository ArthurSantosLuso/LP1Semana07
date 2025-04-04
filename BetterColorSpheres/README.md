classDiagram
    class Color {
        +byte Red
        +byte Green
        +byte Blue
        +byte Alpha
        +byte Gray
        +Color(byte r, byte g, byte b, byte a)
        +Color(byte r, byte g, byte b)
    }

    class Sphere {
        +Color Color
        +float Radius
        +int QtdThrow
        +Sphere(Color sphereColor, float sphereRadius)
        +void Pop()
        +void Throw()
    }

    class Program {
        -static void Main(string[] args)
    }

    Sphere --> Color : has a
    Program --> Sphere : uses
