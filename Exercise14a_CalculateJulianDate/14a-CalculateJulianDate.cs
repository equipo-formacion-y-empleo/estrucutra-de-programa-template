using System;

void CalculateJulianDate(int day, int month, int year)
{
    throw new NotImplementedException();
    // TODO: Implementar cálculo y mostrar resultados:
    // Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
    // Console.WriteLine($"Fecha juliana: {julianDate:F0}");
}

// Obtener argumentos de línea de comandos
int day = args.Length > 0 ? int.Parse(args[0]) : 1;
int month = args.Length > 1 ? int.Parse(args[1]) : 1;
int year = args.Length > 2 ? int.Parse(args[2]) : 2000;

// Calcular fecha juliana
CalculateJulianDate(day, month, year);