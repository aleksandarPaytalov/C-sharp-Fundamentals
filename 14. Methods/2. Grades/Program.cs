using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());        
        printGrade(grade);
    }

    static void printGrade(double inputGrade)
    {
        if (inputGrade >= 2 && inputGrade <= 2.99)
        {
            Console.WriteLine("Fail");
        }
        else if (inputGrade >= 3 && inputGrade <= 3.49)
        {
            Console.WriteLine("Poor");
        }
        else if (inputGrade >= 3.50 && inputGrade <= 4.49)
        {
            Console.WriteLine("Good");
        }
        else if (inputGrade >= 4.50 && inputGrade <= 5.49)
        {
            Console.WriteLine("Very good");
        }
        else
        {
            Console.WriteLine("Excellent");
        }
    }
}