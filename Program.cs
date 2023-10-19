using lab4;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing with positive radius 8");
        Circle c1 = new Circle();
        c1.SetRadius(8);
        Console.WriteLine(c1);

        Console.WriteLine("Testing with negative radius -6");
        Circle c2 = new Circle();
        try
        {
            c2.SetRadius(-6);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Testing with zero radius");
        Circle c3 = new Circle();
        try
        {
            c3.SetRadius(0);
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}