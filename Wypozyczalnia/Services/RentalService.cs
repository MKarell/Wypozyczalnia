using System.Runtime.InteropServices.JavaScript;
using Wypozyczalnia.Domain;

namespace Wypozyczalnia.Services;

public class RentalService
{
    private List<Rent> listOfRents;
    public RentalService()
    {
        listOfRents = new List<Rent>();
    }

    public void AddRent(EquipmentRegistry equipmentRegistry, UserRegistry userRegistry)
    {
        Console.WriteLine("Podaj ID użytkownika");
        User user = userRegistry.GetByID(int.Parse(Console.ReadLine()));
        Console.WriteLine("Podaj ID sprzętu");
        Equipment eq = equipmentRegistry.GetById(int.Parse(Console.ReadLine()));
        Console.WriteLine("Podaj czas wypożyczenia (w dniach)");
        int data = int.Parse(Console.ReadLine());
        if (user.rentEquipments.Count < user.maxHire)
            listOfRents.Add(new Rent(eq, user, DateTime.Now, data));
        else
            Console.WriteLine("Limit wypożyczeń przekroczony");
    }
    
    
}