using Wypozyczalnia.Domain;


namespace Wypozyczalnia.Services;

public class EquipmentRegistry
{
    private List<Equipment> listOfEquipments { get; }

    public EquipmentRegistry()
    {
        listOfEquipments = new List<Equipment>();
    }
    
    public void AddEquipments()
    {
        Console.WriteLine("Podaj nazwe sprzętu:");
        var name = Console.ReadLine();
        Console.WriteLine("1-Laptop, 2-Projektor, 3-Kamera:");
        var eq = int.Parse(Console.ReadLine());
        if (eq == 1)
        {
            Console.WriteLine("Podaj nazwe systemu operacyjnego:");
            var sys = Console.ReadLine();
            Console.WriteLine("Podaj ilość ram w GB:");
            var ram = int.Parse(Console.ReadLine());
            Equipment newEq = new Laptop(true, name, sys, ram);
            listOfEquipments.Add(newEq);
        }
        else if (eq == 2)
        {
            Console.WriteLine("Podaj rozdzielczość:");
            var res = Console.ReadLine();
            Console.WriteLine("Podaj ilość lumenów:");
            var lum = int.Parse(Console.ReadLine());
            Equipment newEq = new Projector(true, name, res, lum);
            listOfEquipments.Add(newEq);
        }
        else if (eq == 3)
        {
            Console.WriteLine("Podaj typ obiektywu:");
            var len = Console.ReadLine();
            Console.WriteLine("Czy zawiera lampę (true/false):");
            var flash = bool.Parse(Console.ReadLine());
            Equipment newEq = new Camera(true, name, len, flash);
            listOfEquipments.Add(newEq);
        }
        else
        {
            Console.WriteLine("Brak wybranej roli");
        }
        Console.Clear();
    }
    
    public string GetAll()
    {
        foreach (var eq in listOfEquipments)
        {
            return eq.ToString();
        }
        return null;
    }
    
    public string GetAll(bool isAvailable)
    {
        foreach (var eq in listOfEquipments)
        {
            if(isAvailable)
                return eq.ToString();
        }
        return null;
    }
}