using Wypozyczalnia.Domain;


namespace Wypozyczalnia.Services;

public class EquipmentRegistry
{
    private List<Equipment> listOfEquipments { get; }

    public EquipmentRegistry()
    {
        listOfEquipments = new List<Equipment>();
    }
    
    public void Add()
    {
        Console.WriteLine("Podaj nazwe sprzętu:");
        var name = Console.ReadLine();
        Console.Write("1-Laptop, 2-Projektor, 3-Kamera");
        var eq = Console.Read();
        if (eq == 1)
        {
            Equipment newEq = new Laptop(true, name);
            listOfEquipments.Add(newEq);
        }
        else if (eq == 2)
        {
            Equipment newEq = new Projector(true, name);
            listOfEquipments.Add(newEq);
        }
        else if (eq == 3)
        {
            Equipment newEq = new Camera(true, name);
            listOfEquipments.Add(newEq);
        }
        else
        {
            Console.WriteLine("Brak wybranej roli");
        }
        Console.Clear();
    }
    
    public List<Equipment> GetAll()
    {
        return listOfEquipments;
    }
    
    public List<Equipment> GetAll(bool isAvailable)
    {
        
        return listOfEquipments;
    }

    public void ChangeStatus(Equipment equipment)
    {
        equipment.Available = !equipment.Available;
    }
}