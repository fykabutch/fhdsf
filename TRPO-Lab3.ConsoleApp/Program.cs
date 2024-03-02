using TRPO_Lab3.ClassLibrary;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус большого круга шара: ");
        double R = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту шарового сегмента: ");
        double h = double.Parse(Console.ReadLine());
        double s = Square.Calc(R,h);
        Console.WriteLine($"Площадь поверхности шарового сектора: {s}");
    }

}