public class AdvancedStudent : Student
{
    private double[] grades;
    public AdvancedStudent(string name, int age) : base(name, age)
    {
        grades = new double[5];
    }
    public void AddGrade(int index, double grade)
    {
        if (index >= 0 && index < grades.Length)
        {
            grades[index] = grade;
            CalculateGPA();
        }
    }
    public new void PrintStudentInfo()
    {
        base.PrintStudentInfo();
        Console.WriteLine($"Grades: {string.Join(", ", grades)}");
    }
    protected void CalculateGPA()
    {
        GPA = grades.Average();
    }
}
