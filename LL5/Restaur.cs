using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Restaur : Publick
{
    public int NumberOfTables { get; set; }
    public Restaur(int yearBuilt, double admissionPrice, int numberOfTables) : base(yearBuilt, 700, "Ресторан")
    {
        NumberOfTables = numberOfTables;
    }
    public void PrintInfo()
    {
        Console.WriteLine($" Будiвля: {Name}\n " +
            $"Рiк побудови: {YearBuilt} \n " +
            $"Тип Будiвлi: {Type}\n " +
            $"Кiлькiсть столикiв: {NumberOfTables} \n " +
            $"Вартiсть для однiєї людини: {GetAdmissionPrice()} \n " +
            $"Мiсткiсть будiвлi: {GetCapacity()}");
    }
    public override int GetCapacity()
    {
        return NumberOfTables * 4;
    }
}
