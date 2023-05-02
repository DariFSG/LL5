using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Building
{
    public int YearBuilt { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public Building(int yearBuilt)
    {
        YearBuilt = yearBuilt;
    }

    public abstract double GetRentalCost();

    public abstract double GetAdmissionPrice();

    public abstract int GetCapacity();
}