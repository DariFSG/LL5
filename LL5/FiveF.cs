using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FiveF : Living
{
    public int NumberOfApartments { get; set; }

    public FiveF(int yearBuilt, double rentalCost, int numberOfApartments) : base(yearBuilt, 9000, "П'ятиповерхiвка")
    {
        NumberOfApartments = numberOfApartments;
    }
    public void PrintInfo()
    {
        Console.WriteLine($" Будiвля: {Name}\n " +
            $"Рiк побудови: {YearBuilt} \n " +
            $"Тип Будiвлi: {Type}\n " +
            $"Кiлькiсть кімнат: {NumberOfApartments} \n " +
            $"Вартiсть за квартиру: {GetRentalCost()} \n " +
            $"Мiсткiсть будiвлi: {GetCapacity()}");
    }
    public override int GetCapacity()
    {
        return NumberOfApartments * 4;
    }
}
