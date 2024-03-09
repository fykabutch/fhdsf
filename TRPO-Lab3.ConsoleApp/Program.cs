using TRPO_Lab3.ClassLibrary;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сторону правильного треугольника: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту правильной треугольной пирамиды: ");
        double h = double.Parse(Console.ReadLine());
        double s = Square.Calc(a,h);
        Console.WriteLine($"Объем правильной треугольной пирамиды: {s}");
        Console.ReadKey();
    }

}