using System.Runtime.ConstrainedExecution;

namespace User;

public abstract class User
{
    private static int _id;
    private string name;
    private string lastName;

    public User(String name, String lastName)
    {
        _id = ++_id;
        this.name = name;
        this.lastName = lastName;
    }
}

public class Student: User
{
    public const int maxHire = 2;
    public Student() : base("Student", null)
    {
        
    }
}

public class Employee : User
{
    public const int maxHire = 5;
    public Employee() :  base("Employee", null)
    {
        
    }
}