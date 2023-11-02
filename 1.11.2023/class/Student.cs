using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentClass : ParentClass
{
    private string speciality;
    public string Specialty { get { return speciality; } set { speciality = value; } }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name : {Name}; Age : {Age}; Specialty  : {Specialty}");
    }
}

// Фабрика для создания объектов наследующего класса
class StudentClassFactory
{
    public static StudentClass CreateStudent(string name, int age, string specialty)
    {
        StudentClass student = new StudentClass();
        student.Name = name;
        student.Age = age;
        student.Specialty = specialty;
        return student;
    }

}