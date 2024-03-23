namespace TRPO_Lab3.ClassLibrary
{
    public class Square
    {
        double a;
        double h;
        public static double Calc(double a, double h)
        {
            if (a < 0 || h < 0)
            {
                throw new Exception();
            }
            return Math.Round((h * Math.Pow(a, 2)) / (4 * Math.Sqrt(3)), 2);
        }
    }
}