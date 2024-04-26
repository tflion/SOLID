namespace SOLID.I;

public class Seller : IFunctionary, IComissionable
{
    public double Wage()
    {
        return 1899.30;
    }
    
    public double GenerateComission()
    {
        double wage = Wage();

        return (wage * 0.20) + wage;
    }
}


