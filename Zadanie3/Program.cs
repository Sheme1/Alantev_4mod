using System.Security.Cryptography.X509Certificates;

public interface Student
{
    public double SredBall();
    public void InfKurs();
}

class POIT : Student
{
    private double y;
    public double SredBall()
    {

        Console.WriteLine("Введите количетсво отметок");
        int a = Convert.ToInt32(Console.ReadLine());   
        Console.WriteLine("Введите отметки разделитель пробел");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Парсинг введенных чисел
            if (int.TryParse(inputArray[i], out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Некорректный ввод числа.");
            }
        }
        int x = 0;
        for (int i = 0; i < numbers.Length; i ++)
        {
            x = numbers[i] + x;
            
        }
        y = (double)x / a;
        Console.WriteLine(y);
        return y;
    }

    public void InfKurs()
    {
        Console.WriteLine("Введите год обучения");
        string s = Console.ReadLine();
        s = s.Substring(2);
        Console.WriteLine("Введите курс");
        int kurs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ФИО");
        string fio = Console.ReadLine();
        Console.WriteLine($"Группа: " + kurs + "ПОИТ" + s + $" {fio}" + $" Средний балл: {y}");
    }
}


class FK : Student
{
    private double y;
    public double SredBall()
    {

        Console.WriteLine("Введите количетсво отметок");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите отметки разделитель пробел");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Парсинг введенных чисел
            if (int.TryParse(inputArray[i], out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Некорректный ввод числа.");
            }
        }
        int x = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            x = numbers[i] + x;

        }
        y = (double)x / a;
        Console.WriteLine(y);
        return y;
    }

    public void InfKurs()
    {
        Console.WriteLine("Введите год обучения");
        string s = Console.ReadLine();
        s = s.Substring(2);
        Console.WriteLine("Введите курс");
        int kurs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ФИО");
        string fio = Console.ReadLine();
        Console.WriteLine($"Группа: " + kurs + "ФК" + s + $" {fio}" + $" Средний балл: {y}");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        bool isComplet = true;
        do
        {
            Console.WriteLine("Выберите группу");
            Console.WriteLine("1. ПОИТ");
            Console.WriteLine("2. ФК");
            Console.WriteLine("3. Выход");
            int variant = Convert.ToInt32(Console.ReadLine());
            switch (variant)
            {
                case 1:
                    POIT poit = new POIT();
                    poit.SredBall();
                    poit.InfKurs();
                    break;
                case 2:
                    FK fk = new FK();
                    fk.SredBall();
                    fk.InfKurs();
                    break;
                case 3:
                    isComplet = false;
                    break;
                default:
                    Console.WriteLine("Вы ввели не коректный вариант");
                    break;
            }
        } while (isComplet);
    }
}
