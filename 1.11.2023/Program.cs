using System;
using System.Collections.Generic;

// Родительский класс
abstract class ParentClass
{
    private string name;
    private int age;
    public string Name { get {return name; } set {name = value; } }
    public int Age { get { return age; } set { age = value; } }

    abstract public void ShowInfo();
}

// Наследующий класс


class Program
{
    static void Main(string[] args)
    {
        // Храню свои объекты в списке
        List<ParentClass> persons = new List<ParentClass>();
        persons.Add(ChildClassFactory.CreateChild("Alice", 5, "painting"));
        persons.Add(StudentClassFactory.CreateStudent("Marsel", 15, "Programmer"));
        persons.Add(WorkerClassFactory.CreateWorker("Charlie", 30, "cooking"));
        persons.Add(WorkerClassFactory.CreateWorker("Chen", 29, "banker"));
        persons.Add(WorkerClassFactory.CreateWorker("Clara", 60, "IT-Manager")); 
        persons.Add(StudentClassFactory.CreateStudent("Valera", 15, "Veb-developer"));
        persons.Add(ChildClassFactory.CreateChild("Alina", 8, "Computer games"));



        // Сортировка объектов по возрасту (пузырьковая сортировка)
        for (int i = 0; i < persons.Count - 1; i++)
        {
            for (int j = 0; j < persons.Count - i - 1; j++)
            {
                if (persons[j].Age > persons[j + 1].Age)
                {
                    ParentClass temp = persons[j];
                    persons[j] = persons[j + 1];
                    persons[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Child");
        foreach (var c in persons)
        {
            if (c is ChildClass)
            {
                c.ShowInfo();
            }
        }

        Console.WriteLine("Students");
        foreach (var c in persons)
        {
            if (c is StudentClass)
            {
                c.ShowInfo();
            }
        }

        Console.WriteLine("Workers");
        foreach (var c in persons)
        {
            if (c is WorkerClass)
            {
                c.ShowInfo();
            }
        }
    }
}