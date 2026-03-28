namespace Wypozyczalnia.Domain;

public abstract class User
{
    private static int _id;
    private string name;
    private string lastName;
    public List<Equipment> rentEquipments;

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
    public Student(string name, string lastName) : base(name, lastName) { }
}

public class Employee : User
{
    public const int maxHire = 5;

    public Employee(string name, string lastName) : base(name, lastName) { }
}