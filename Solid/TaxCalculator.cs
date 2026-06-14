namespace Solid;

public class TaxCalculator
{
    
    public virtual decimal CalculateTax(decimal amount)
    {
        return amount * 0.1m;
    }
}
