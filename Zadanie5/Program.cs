using System;

// Интерфейс "Рисунок"
public interface IDrawing
{
    void DrawLine();
    void DrawCircle();
    void DrawRectangle();
}

// Класс "Холст", реализующий интерфейс "Рисунок"
public class Canvas : IDrawing
{
    public void DrawLine()
    {
        Console.WriteLine("Рисуем линию...");
    }

    public void DrawCircle()
    {
        Console.WriteLine("Рисуем круг...");
    }

    public void DrawRectangle()
    {
        Console.WriteLine("Рисуем прямоугольник...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Canvas canvas = new Canvas();

        canvas.DrawLine();
        canvas.DrawCircle();
        canvas.DrawRectangle();

        Console.ReadKey();
    }
}
