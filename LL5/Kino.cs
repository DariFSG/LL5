using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Kino : Publick
{
    public int NumberOfScreens { get; set; }

    public Kino(int yearBuilt, double admissionPrice, int numberOfScreens, string Name) : base(yearBuilt, 200, "Кiно")
    {
        NumberOfScreens = numberOfScreens;
    }
    public void PrintInfo()
    {
        Console.WriteLine($" Будiвля: {Name}\n " +
            $"Рiк побудови: {YearBuilt} \n " +
            $"Тип Будiвлi: {Type}\n " +
            $"Кiлькiсть залів: {NumberOfScreens} \n " +
            $"Вартiсть квитка: {GetAdmissionPrice()} \n " +
            $"Мiсткiсть будiвлi: {GetCapacity()}");
    }
    public override int GetCapacity()
    {
        return NumberOfScreens * 200; // нехай в кожному залі кінотеатру по 200 місць
    }
}
