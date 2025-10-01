using System;

double CalculateJulianDate(int day, int month, int year)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int day = args.Length > 0 ? int.Parse(args[0]) : 1;
int month = args.Length > 1 ? int.Parse(args[1]) : 1;
int year = args.Length > 2 ? int.Parse(args[2]) : 2000;

// Probar la función
double julianDate = CalculateJulianDate(day, month, year);

// Mostrar resultado
Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
Console.WriteLine($"Fecha juliana: {julianDate:F0}");