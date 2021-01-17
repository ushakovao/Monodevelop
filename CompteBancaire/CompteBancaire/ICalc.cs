using System;
namespace CompteBancaire
{
    public interface ICalc
    {
        double Icalc(double solde);
        double Taux { get;  }
    }
}