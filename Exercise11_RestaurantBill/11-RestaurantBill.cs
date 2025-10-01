const double EUR_TO_USD = 1.09;
const double EUR_TO_JPY = 163.5;
const double EUR_TO_GBP = 0.86;

(double usd, double jpy, double gbp) ConvertCurrencies(double euros)
{
    throw new NotImplementedException();
}

double euros = double.Parse(args.Length > 0 ? args[0] : "100,0");
var (usd, jpy, gbp) = ConvertCurrencies(euros);

Console.WriteLine($"€{euros:F2} = ${usd:F2} USD");
Console.WriteLine($"€{euros:F2} = ¥{jpy:F2} JPY");
Console.WriteLine($"€{euros:F2} = £{gbp:F2} GBP");
