namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первую фразу:");
        string _phrase1 = Console.ReadLine() ?? "Привет";
        Console.WriteLine("Введите вторую фразу:");
        string _phrase2 = Console.ReadLine() ?? " Мир !";

        string _completedText = _phrase1 + _phrase2;
        Console.WriteLine(_completedText);
    }
}
