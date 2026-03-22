public class  Wypozyczalnia
{
    static void Main()
    {
        var active = true;
        //lista sprzętu
        //lista użytkowników
        
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
        int expression = Console.Read();

        while (active)
        {
            switch (expression)
            {
                case 1:
                    Console.WriteLine("Podaj imie:");
                    var name = Console.ReadLine();
                    Console.Write("Podaj nazwisko: ");
                    var lastName = Console.ReadLine();
                    Console.Write("1-Student, 2-Employee ");
                    var user = Console.Read();
                    if (user == 1)
                    {
                        User.User employee = new User.Student();
                    }
                    else if (user == 2)
                    {
                        User.User employee = new User.Employee();
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
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
                    break;
                default: Console.Write("Brak takiej funkcjonalności");
                    break;
            }
            Console.Clear();
        }
    }
}