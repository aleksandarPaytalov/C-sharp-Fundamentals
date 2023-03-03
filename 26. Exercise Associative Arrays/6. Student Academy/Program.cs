int n = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
for (int i = 0; i < n; i++)
{
    string studentName = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    
    if (!students.ContainsKey(studentName))
    {
        List<double> currentStudentGrade = new List<double>();
        students.Add(studentName, currentStudentGrade);
    }
    students[studentName].Add(grade);
}

foreach (var student in students)
{
    int gradesCount = student.Value.Count;
    double averageGrade = student.Value.Sum(x => x / gradesCount);

    if (averageGrade >= 4.50)
    {
        Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
    }
}