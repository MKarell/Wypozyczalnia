using Wypozyczalnia.Domain;

namespace Wypozyczalnia.Services;

public class UserRegistry
{
    public static List<User> listOfUsers;

    public UserRegistry()
    {
        listOfUsers = new List<User>();
    }

    public void AddUser()
    {
        Console.WriteLine("Podaj imie:");
        var name = Console.ReadLine();
        Console.Write("Podaj nazwisko: ");
        var lastName = Console.ReadLine();
        Console.Write("1-Student, 2-Employee ");
        var user = Console.Read();
        if (user == 1)
        {
            User newUser = new Student(name, lastName);
            listOfUsers.Add(newUser);
        }
        else if (user == 2)
        {
            User newUser = new Employee(name, lastName);
            listOfUsers.Add(newUser);
        }
        else
        {
            Console.WriteLine("Brak wybranej roli");
        }
        Console.Clear();
    }

    public User GetByID(int id)
    {
        foreach (var eq in listOfUsers)
        {
            if(id == eq.ID)
                return eq;
        }
        return null;
    }
}