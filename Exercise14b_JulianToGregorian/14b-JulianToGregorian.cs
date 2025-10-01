using System;

(int day, int month, int year) JulianToGregorian(double julianDay)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
double julianDay = args.Length > 0 ? double.Parse(args[0]) : 2451545;

// Probar la función
var (day, month, year) = JulianToGregorian(julianDay);

// Mostrar resultado
Console.WriteLine($"Fecha juliana: {julianDay:F0}");
Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");