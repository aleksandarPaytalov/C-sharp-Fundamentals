string input = string.Empty;
List<Student> students = new List<Student>();

while ((input = Console.ReadLine()) != "end")
{
    string[] studentInfo = input.Split();
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    int age = int.Parse(studentInfo[2]);
    string homeTown = studentInfo[3];

    bool studentExist = false;

    foreach (var student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            student.Age = age;
            student.HomeTown = homeTown;
            studentExist = true;
            break;
        }
    }
    //studentExist = students.Any(x => x.FirstName == firstName && x.LastName == lastName);
    if (!studentExist)
    {
        Student student = new Student
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = homeTown,        
        };        
    }  
}
string studentsHomeTown = Console.ReadLine();

foreach (var student in students)
{
    if (student.HomeTown == studentsHomeTown)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}

