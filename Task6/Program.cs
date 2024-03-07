namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("For: ");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(i);
        }

        Console.WriteLine("While: ");
        int _counter = 0;
        while (_counter < 10) {
            Console.WriteLine(_counter);
            _counter++;
        }

        Console.WriteLine("Do-While: ");
        _counter = 0;
        do {
            Console.WriteLine(_counter);
            _counter++;
        } while (_counter < 10);

        Console.WriteLine("For с фразами: ");
        string _text = "";
        for (int i = 0; i < 2; i++) {
            Console.WriteLine($"Введите фразу #{i+1}");
            _text += " " + Console.ReadLine();
        }
        Console.WriteLine($"Введенный текст: {_text}");
    }
}
