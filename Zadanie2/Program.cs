using System.ComponentModel.Design;
using System.Drawing;

public interface Product
{
    string Price();
    string Balance();
}

class Lumber : Product
{
    public string Price()
    {
        return "Стоимость досок: 15р";
    }

    public string Balance()
    {
        return "Остаток на складе: 1000шт";
    }
}

class BuildingMaterial : Product
{
    public string Price()
    {
        return "Стоимость кирпичей: 20р";
    }

    public string Balance()
    {
        return "Остаток на складе: 100000шт";
    }
}

class Tools : Product
{
    public string Price()
    {
        return "Стоимость молотка: 35р";
    }
    
    public string Balance()
    {
        return "Остаток на кладе: 15000шт";
    }
}

class Programm
{
    static void Main(string[] args)
    {
        Lumber lumber = new Lumber();
        BuildingMaterial material = new BuildingMaterial();
        Tools tool = new Tools();
        View(lumber);
        View(material);
        View(tool);
    }
    static void View(Product product)
    {
        string a;
        if (product.GetType() == typeof(Lumber))
        {
            a = "Пиломатериалы";
        }
        else if (product.GetType() == typeof(BuildingMaterial))
        {
            a = "Стройматериалы";
        }
        else
        {
            a = "Инструменты";
        }
        Console.WriteLine($"{a} {product.Price()}");
        Console.WriteLine($"{a} {product.Balance()}");
    }
}