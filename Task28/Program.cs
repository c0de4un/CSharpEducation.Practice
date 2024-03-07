namespace Task28;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int MAX_BOOKS = rnd.Next(9, 99);
        Book[] _books = new Book[MAX_BOOKS];

        for (int i = 0; i < MAX_BOOKS; i++) {
            _books[i] = new Book();
        }

        System.Console.WriteLine($"Количество книг = {Book.countInstances()}");
    }
}
