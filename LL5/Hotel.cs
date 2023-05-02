using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Hotel : Living
{
    public int NumberOfRooms { get; set; }
    public Hotel(int yearBuilt, double RentalCost, string Name, string Type, int numberOfRooms) : base(yearBuilt, 1000, "Готель")
    {
        NumberOfRooms = numberOfRooms;
    }
    public void PrintInfo()
    {
        Console.WriteLine($" Будiвля: {Name}\n " +
            $"Рiк побудови: {YearBuilt} \n " +
            $"Тип Будiвлi: {Type}\n " +
            $"Кiлькiсть кімнат: {NumberOfRooms} \n " +
            $"Вартiсть: {GetRentalCost()} \n " +
            $"Мiсткiсть будiвлi: {GetCapacity()}");
    }

    public override int GetCapacity()
    {
        return NumberOfRooms * 2;
    }

}
