using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Living : Building
{
    public double RentalCostPerSquareMeter { get; set; }

    public Living(int yearBuilt, double rentalCostPerSquareMeter, string name) : base(yearBuilt)
    {
        RentalCostPerSquareMeter = rentalCostPerSquareMeter;
        Name = name;
        Type = "Житлова будiвля";
    }

    public override double GetRentalCost()
    {
        return RentalCostPerSquareMeter / 10.0;
    }
    public override int GetCapacity()
    {
        return 0;
    }
    public override double GetAdmissionPrice()
    {
        return 0;
    }
}