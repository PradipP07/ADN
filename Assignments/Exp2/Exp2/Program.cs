using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    //Data Members- EnCapsulation
    private String name;
    private int age;

    //Methods
    public void setData(String n, int a) 
    {
        name = n; 
        age = a;
    }
    public void display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}
namespace Exp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object
            Student s = new Student();
            s.setData("Pradip", 21);
            s.display();

            Console.ReadLine();
        }
    }
}
