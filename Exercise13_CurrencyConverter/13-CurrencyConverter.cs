const double EUR_TO_USD = 0.0;
const double EUR_TO_JPY = 0.0;
const double EUR_TO_GBP = 0.0;

double ConvertCurrency()
{
    throw new NotImplementedException();
}

double euros = double.Parse(args.Length > 0 ? args[0] : "100.0");

Console.WriteLine($"€{euros:F2} = ${ConvertCurrency():F2} USD");
Console.WriteLine($"€{euros:F2} = ¥{ConvertCurrency():F2} JPY");
Console.WriteLine($"€{euros:F2} = £{ConvertCurrency():F2} GBP");