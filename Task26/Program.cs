namespace Task26;

class Program
{
    static void Main(string[] args)
    {
        Person adult = new Person();
        adult.mName = "Денис";
        adult.mAge = 16;
        System.Console.WriteLine($"{adult.mName} взрослый {adult.CheckIsAdult()}?");

        Person underAge = new Person();
        underAge.mName = "Женя";
        underAge.mAge = 18;
        System.Console.WriteLine($"{underAge.mName} взрослый {adult.CheckIsAdult()}?");
    }
}
