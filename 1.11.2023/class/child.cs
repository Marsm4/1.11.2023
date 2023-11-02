class ChildClass : ParentClass
{
    private string hobby;
    public string Hobby { get { return hobby; } set { hobby = value; } }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name : {Name}; Age : {Age}; Hobby : {Hobby}");
    }
}

// Фабрика для создания объектов наследующего класса
class ChildClassFactory
{
    public static ChildClass CreateChild(string name, int age, string hobby)
    {
        ChildClass child = new ChildClass();
        child.Name = name;
        child.Age = age;
        child.Hobby = hobby;
        return child;
    }
}