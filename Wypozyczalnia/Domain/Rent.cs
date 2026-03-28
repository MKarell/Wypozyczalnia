namespace Wypozyczalnia.Domain;

public class Rent
{
    public DateTime RentDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }

    public Rent(Equipment equipment, User borrower, DateTime rentDate, int days)
    {
        RentDate = rentDate;
        DueDate = rentDate.AddDays(days);
        borrower.rentEquipments.Add(equipment);
    }
}