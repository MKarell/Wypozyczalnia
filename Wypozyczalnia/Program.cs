using Wypozyczalnia.Domain;
using Wypozyczalnia.Services;
public class Program
{
    static void Main()
    {
        var active = true;
        UserRegistry users = new UserRegistry();
        EquipmentRegistry equipments = new EquipmentRegistry();

        while (active)
        {
            Console.Clear();
            Console.WriteLine("Uczelniana wypozyczalnia sprzetu: ");
            Console.WriteLine("1. Dodanie nowego użytkwonika do systemu");
            Console.WriteLine("2. Dodanie nowego sprzętu");
            Console.WriteLine("3. Wyświetlnie listy całego sprzętu");
            Console.WriteLine("4. Wyświetlenie wypożyczonego sprzętu");
            Console.WriteLine("5. Wypożyczenie sprzetu");
            Console.WriteLine("6. Zwrot sprzętu"); //może w 8
            Console.WriteLine("7. Oznaczenie sprzętu jako niedostępnego"); //to w liście sprzętu
            Console.WriteLine("8. Wyświetlenie aktywnych wypożyczeń użytkownika"); 
            Console.WriteLine("9. Wyświetlenie listy przeterminowanych wypożyczeń");
            Console.WriteLine("10. Wygenerowanie raportu podsumowującego stan wypożyczalni");
            Console.WriteLine("11. Wyjście");
            var expresion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (expresion)
            {
                
                case 1:
                    users.AddUser();
                    break;
                case 2:
                    equipments.AddEquipments();
                    break;
                case 3:
                    Console.WriteLine(equipments.GetAll());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(equipments.GetAll(true));
                    Console.ReadKey();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11: active=false;
                    Console.WriteLine("Żegnam");
                    break;
                default: Console.Write("Brak takiej funkcjonalności");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}