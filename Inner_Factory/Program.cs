using Inner_Factory;

public class Program
{
    public static void Main(string[] args)
    {
        var cartesianPoint = Point.Factory.NewCartesianPoint(3, 4);

        var polarPoint = Point.Factory.NewPolarPoint(5, Math.PI / 4);
    }
}