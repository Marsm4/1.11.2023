using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class WorkerClass : ParentClass
{
    private string profession;
    public string Profession { get { return profession; } set {profession = value; } }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name : {Name}; Age : {Age}; Profession  : {Profession}");
    }
}

// Фабрика для создания объектов наследующего класса
class WorkerClassFactory
{
    public static WorkerClass CreateWorker(string name, int age, string profession)
    {
        WorkerClass worker = new WorkerClass();
        worker.Name = name;
        worker.Age = age;
        worker.Profession = profession;
        return worker;
    }
}