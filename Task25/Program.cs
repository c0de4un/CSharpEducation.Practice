namespace Task25;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.mName = "Денис";
        person.mAge = 32;
        System.Console.WriteLine($"Имя {person.mName} Возраст {person.mAge}");
    }
}
