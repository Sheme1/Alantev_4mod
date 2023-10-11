
// Интерфейс "Книга"
public interface IBook
{
    string Title { get; }
    bool IsAvailable { get; }
    void Issue();
}

// Класс "Роман"
public class Novel : IBook
{
    public string Title { get; private set; }
    public bool IsAvailable { get; private set; }

    public Novel(string title)
    {
        Title = title;
        IsAvailable = true;
    }

    public void Issue()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"Книга '{Title}' выдана.");
        }
        else
        {
            Console.WriteLine($"Книга '{Title}' недоступна.");
        }
    }
}

// Класс "Учебник"
public class Textbook : IBook
{
    public string Title { get; private set; }
    public bool IsAvailable { get; private set; }

    public Textbook(string title)
    {
        Title = title;
        IsAvailable = true;
    }

    public void Issue()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"Учебник '{Title}' выдан.");
        }
        else
        {
            Console.WriteLine($"Учебник '{Title}' недоступен.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool isCompled = true;
        int variant;
        Dictionary<string, IBook> books = new Dictionary<string, IBook>();

        do
        {
            Console.WriteLine("Выберите вариант: ");
            Console.WriteLine("1. Роман");
            Console.WriteLine("2. Учебник");
            Console.WriteLine("3. Выход");
            variant = Convert.ToInt32(Console.ReadLine());

            switch (variant)
            {
                case 1:
                    Console.WriteLine("Введите название романа");
                    string s = Console.ReadLine();
                    if (books.ContainsKey(s) && !books[s].IsAvailable)
                    {
                        Console.WriteLine($"Книга '{s}' недоступна.");
                    }
                    else
                    {
                        IBook novel = new Novel(s);
                        novel.Issue();
                        books[s] = novel;
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите название учебника");
                    string f = Console.ReadLine();
                    if (books.ContainsKey(f) && !books[f].IsAvailable)
                    {
                        Console.WriteLine($"Учебник '{f}' недоступен.");
                    }
                    else
                    {
                        IBook textbook = new Textbook(f);
                        textbook.Issue();
                        books[f] = textbook;
                    }
                    break;
                case 3:
                    isCompled = false;
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильно число");
                    continue;
            }
        } while (isCompled);

    }
}