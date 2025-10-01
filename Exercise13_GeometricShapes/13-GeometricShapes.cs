long CalculateJulianDate(int day, int month, int year)
{
    throw new NotImplementedException();
}

(int day, int month, int year) JulianToGregorian(long julianDay)
{
    throw new NotImplementedException();
}

int day = int.Parse(args.Length > 0 ? args[0] : "15");
int month = int.Parse(args.Length > 1 ? args[1] : "10");
int year = int.Parse(args.Length > 2 ? args[2] : "2024");

long julianDate = CalculateJulianDate(day, month, year);
var (gregDay, gregMonth, gregYear) = JulianToGregorian(julianDate);

Console.WriteLine($"Fecha gregoriana: {day:D2}/{month:D2}/{year}");
Console.WriteLine($"Fecha juliana: {julianDate}");
Console.WriteLine($"Conversión inversa: {gregDay:D2}/{gregMonth:D2}/{gregYear}");
