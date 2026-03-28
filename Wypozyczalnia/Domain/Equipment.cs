namespace Wypozyczalnia.Domain;

public abstract class Equipment
{
    public static int id = 0;
    private bool available {get; set;}
    public bool Available {get => available; set => available = value; }
    private string name;
    public string Name {get => name;}
    
    protected Equipment(bool available, string name)
    {
        id = ++id;
        this.available = available;
        this.name = name;
    }
}

public class Laptop: Equipment
{
    public Laptop(bool available, string name) : base(available, name)
    {
        
    }
}

public class Projector: Equipment
{
    public Projector(bool available, string name) : base(available, name)
    {
        
    }
}

public class Camera : Equipment
{
    public Camera(bool available, string name) : base(available, name)
    {
        
    }
}