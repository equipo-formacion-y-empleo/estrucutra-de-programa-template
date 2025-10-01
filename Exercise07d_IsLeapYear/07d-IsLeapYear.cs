bool IsLeapYear(int year)
{
    throw new NotImplementedException();
}

int year = int.Parse(args.Length > 0 ? args[0] : "2024");

Console.WriteLine($"¿Es {year} un año bisiesto? {IsLeapYear(year)}");