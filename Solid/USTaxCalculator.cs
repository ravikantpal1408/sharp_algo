namespace Solid;

public class USTaxCalculator : TaxCalculator
{

    public override decimal CalculateTax(decimal amount)
    {
        return amount * 0.8m;
    }
}
