namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вычисляем катет и гипотенузу . . .");

        double _katet1 = 15.2;
        double _katet2 = 19.3;
        double _gypotenusa = Math.Sqrt(_katet1 * _katet1 + _katet2 * _katet2);
        Console.WriteLine("Известны два катета, гипотенуза=" + _gypotenusa);

        _gypotenusa = 24.56;
        _katet2 = Math.Sqrt(_gypotenusa * _gypotenusa - _katet1 * _katet1);
        Console.WriteLine("Известен один катет и гипотенуза, второй катет=" + _katet2);
    }
}
