namespace Wypozyczalnia.Domain;

public abstract class Equipment
{
    public static int id = 0;
    private bool available;
    private string name;
    public string Name {get => name;}
    
    protected Equipment(bool available, string name)
    {
        id = ++id;
        this.available = available;
        this.name = name;
    }
    public void ChangeStatus()
    {
        available = !available;
    }

    public override string ToString()
    {
        return "Type: " + this.GetType() + ", ID: " + id + ", Name: " + this.Name;
    }
}

public class Laptop: Equipment
{
    public string operetingSystem {get; }
    public int ramGB { get; set; }
    public Laptop(bool available, string name, string operetingSystem, int ramGb) : base(available, name)
    {
        this.operetingSystem = operetingSystem;
        this.ramGB = ramGb;
    }
    
    public override string ToString()
    {
        return "Typ: " + this.GetType() + ", ID: " + id + ", Nazwa: " + this.Name + "System operacyjny: " + this.operetingSystem + ", RAM[GB]: " + this.ramGB;
    }
}

public class Projector: Equipment
{
    public string resolution { get; }
    public int lumens { get; }
    public Projector(bool available, string name, string resolution, int lumens) : base(available, name)
    {
        this.resolution = resolution;
        this.lumens = lumens;
    }
    
    public override string ToString()
    {
        return "Typ: " + this.GetType() + ", ID: " + id + ", Nazwa: " + this.Name + ", Rozdzielczosc: " + this.resolution + ", Lumeny: " + this.lumens;
    }
}

public class Camera : Equipment
{
    public string lensTYpe { get; }
    public bool hasFlash { get; }
    public Camera(bool available, string name, string lensTYpe, bool hasFlash) : base(available, name)
    {
        this.lensTYpe = lensTYpe;
        this.hasFlash = hasFlash;
    }
    
    public override string ToString()
    {
        return "Typ: " + this.GetType() + ", ID: " + id + ", Nazwa: " + this.Name + ", Typ obiektywu: " + this.lensTYpe + ", Czy ma lampe: " + this.hasFlash;
    }
}