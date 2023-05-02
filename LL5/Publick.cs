using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Publick : Building
{
    public double AdmissionPrice { get; set; }

    public Publick(int yearBuilt, double admissionPrice, string name) : base(yearBuilt)
    {
        AdmissionPrice = admissionPrice;
        Name = name;
        Type = "Громадська будiвля";
    }
    public override double GetRentalCost()
    {
        return 0;
    }

    public override double GetAdmissionPrice()
    {
        return AdmissionPrice;
    }
    public override int GetCapacity()
    {
        return 0;
    }
}
