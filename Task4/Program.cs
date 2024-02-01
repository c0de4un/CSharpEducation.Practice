namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        const double PI = 3.1415926535897931;

        const double _rad = 35.0;
        double _area = _rad * PI;
        Console.WriteLine($"Площадь круга, используя константу: {_area}");

        _area = _rad * Math.PI;
        Console.WriteLine($"Площадь круга, используя константу: {_area}");
    }
}
