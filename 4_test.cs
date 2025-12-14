class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("John Doe", 20);
        AdvancedStudent student2 = new AdvancedStudent("Jane Smith", 22);
        student1.PrintStudentInfo();
        student2.PrintStudentInfo();
    }
}
