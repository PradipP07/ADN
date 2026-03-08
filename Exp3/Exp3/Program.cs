using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

// Class responsible for calculating grade
class GradeCalculator
{
    public string CalculateGrade(int marks)
    {
        if (marks >= 75)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 50)
            return "C";
        else
            return "Fail";
    }
}

// Class responsible for displaying student information
class StudentPrinter
{
    public void Print(Student student, string grade)
    {
        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Marks: " + student.Marks);
        Console.WriteLine("Grade: " + grade);
    }
}

namespace Exp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Pradip";
            s.Marks = 72;

            GradeCalculator gc = new GradeCalculator();
            string grade = gc.CalculateGrade(s.Marks);

            StudentPrinter printer = new StudentPrinter();
            printer.Print(s, grade);

            Console.ReadLine();
        }
    }
}
