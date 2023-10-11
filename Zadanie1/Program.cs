using System.ComponentModel.Design;

public interface Figura
{
    double Area();
    double Perimetr();
}

public class Circle : Figura
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double Perimetr()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Figura
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area()
    {
        return width * height;
    }

    public double Perimetr()
    {
        return 2 * (width + height);
    }
}

class Triangle : Figura
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Perimetr()
    {
        return a + b + c;
    }

    public double Area()
    {
        double p = Perimetr() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус круга");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine("Введите ширину прямоугольника");
        double wight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту прямоугольника");
        double height = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(wight,height);
        Console.WriteLine("Введите первую сторону треугольника");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону треугольника");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите третию сторону треугольника");
        double c = Convert.ToDouble(Console.ReadLine());
        Triangle triangle = new Triangle(a,b,c);
        View(circle);
        View(rectangle);
        View(triangle);
    }

    static void View(Figura figura)
    {
        string a;
        if (figura.GetType() == typeof(Circle))
        {
            a = "Кругa";
        }
        else if (figura.GetType() == typeof(Rectangle))
        {
            a = "Прямоугольникa";
        }
        else
        {
            a = "Треугольникa";
        }
        Console.WriteLine($"Площадь: {a} {figura.Area()}");
        Console.WriteLine($"Периметр: {a} {figura.Perimetr()}");
    }
}