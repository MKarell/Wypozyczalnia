namespace Equipment;

public abstract class Equipment
{
    private static int id;
    private bool available;
    
    protected Equipment()
    {
        id = ++id;
    }
}

public class Laptop: Equipment
{
    public Laptop()
    {
        //Equipment();
    }
}

public class Projector: Equipment
{
    public Projector()
    {
        
    }
}

public class Camera : Equipment
{
    public Camera()
    {
        
    }
}