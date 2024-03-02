namespace TRPO_Lab3.ClassLibrary
{
    public class Square
    {
        double S;
        double R;
        double h;
        public static double Calc(double R, double h)
        {
            return Math.Round(2 * Math.PI * R * h,2);
        }
    }
}