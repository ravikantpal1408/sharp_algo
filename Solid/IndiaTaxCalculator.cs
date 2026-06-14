namespace Solid;

public class IndiaTaxCalculator : TaxCalculator
{
    public override decimal CalculateTax(decimal amount)
    {
        return amount * 0.15m;
    }
}
