namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет !");
        Console.WriteLine("Введите свое имя: ");
        string _name = Console.ReadLine() ?? "He указано";
        Console.WriteLine("Вы ввели имя: " + _name);
    }
}
