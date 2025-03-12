public class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());

        double area = GetArea(width, heigth);
        Console.WriteLine(area);
        
    }
    static double GetArea(double width, double heigth)
    {
        double area = width * heigth;
        return area;
    }

}

