using System;
namespace StudentApp
{
    public class Student
    {
        private string name;
        public int Age { get; private set; }
        protected double GPA;
        public Student(string name, int age)
        {
            this.name = name;
            this.Age = age;
            this.GPA = 0.0;
        }
        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student: {name}, Age: {Age}, GPA: {GPA}");
        }
        protected void SetGPA(double gpa)
        {
            if (gpa < 0 || gpa > 4.0)
                throw new ArgumentException("Invalid GPA value");
            GPA = gpa;
        }
        private void ChangeName(string newName)
        {
            name = newName;
        }
    }
}
