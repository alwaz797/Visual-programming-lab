using System;

public enum Dept
{
    ComputerScience,
    Mathematics,
    Physics,
    Chemistry,
    Biology
}

public class Individual
{
    private string fullName;

    public Individual() : this(null) { }

    public Individual(string name)
    {
        fullName = name;
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
}

public class Scholar : Individual
{
    private string registrationNumber;
    private int studentAge;
    private Dept course;

    public Scholar() : this(null, 0, Dept.ComputerScience) { }

    public Scholar(string name, string regNo, int age, Dept program) : base(name)
    {
        registrationNumber = regNo;
        studentAge = age;
        course = program;
    }

    public string RegistrationNumber
    {
        get { return registrationNumber; }
        set { registrationNumber = value; }
    }

    public int StudentAge
    {
        get { return studentAge; }
        set { studentAge = value; }
    }

    public Dept Course
    {
        get { return course; }
        set { course = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Scholar scholar1 = new Scholar("Alice", "S123", 20, Dept.ComputerScience);
        Console.WriteLine($"Name: {scholar1.FullName}, RegNo: {scholar1.RegistrationNumber}, Age: {scholar1.StudentAge}, Program: {scholar1.Course}");

        Scholar scholar2 = new Scholar();
        Console.WriteLine($"Name: {scholar2.FullName}, RegNo: {scholar2.RegistrationNumber}, Age: {scholar2.StudentAge}, Program: {scholar2.Course}");
    }
}
