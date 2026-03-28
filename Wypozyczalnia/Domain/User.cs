namespace Wypozyczalnia.Domain;

public abstract class User
{
    private static int _id;
    public int ID { get; }
    private string name;
    private string lastName;
    public int maxHire;
    public List<Equipment> rentEquipments {get; set;}

    public User(String name, String lastName)
    {
        ID = ++_id;
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