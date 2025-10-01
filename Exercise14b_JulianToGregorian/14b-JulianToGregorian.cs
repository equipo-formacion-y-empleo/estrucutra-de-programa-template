using System;

void JulianToGregorian(double julianDay)
{
    throw new NotImplementedException();
    // TODO: Implementar conversión y mostrar resultados:
    // Console.WriteLine($"Fecha juliana: {julianDay:F0}");
    // Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
}

// Obtener argumentos de línea de comandos
double julianDay = args.Length > 0 ? double.Parse(args[0]) : 2451545;

// Convertir fecha juliana a gregoriana
JulianToGregorian(julianDay);