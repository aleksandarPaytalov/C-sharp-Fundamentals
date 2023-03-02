int n = int.Parse(Console.ReadLine());

List<Students> students = new List<Students>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string firstName = input[0];
    string lastName = input[1];
    double grade = double.Parse(input[2]);

    Students student = new Students(firstName, lastName, grade);
    students.Add(student);
}

foreach (var student in students.OrderByDescending(x => x.Grade))
{
    Console.WriteLine(student);
}
public class Students
{
    public Students(string firstName, string lastName, double grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;    
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
    }
}