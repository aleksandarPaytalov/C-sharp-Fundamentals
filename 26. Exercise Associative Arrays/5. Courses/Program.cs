Dictionary<string, List<string>> courses = 
    new Dictionary<string, List<string>>();

int counter = 0;
string input = string.Empty;
while ((input = Console.ReadLine()) != "end")
{
    string[] cmdArg = input.Split(" : ");
    string courseName = cmdArg[0];
    string studentName = cmdArg[1];

    if (!courses.ContainsKey(courseName))
    {
        courses.Add(courseName, new List<string>());        
    }
    courses[courseName].Add(studentName);
    counter++;
}

//foreach (var course in courses)
//{   
//    string courseName = course.Key;
//    List<string> students = course.Value;
//    Console.WriteLine($"{courseName}: {students.Count}");
//
//    foreach (var student in students)
//    {
//        Console.WriteLine($"-- {student}");
//    }
//}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");

    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}