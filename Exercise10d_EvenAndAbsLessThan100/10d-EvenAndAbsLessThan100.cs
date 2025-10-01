using System;

bool EvenAndAbsLessThan100(int number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 50;

// Probar la función
bool result = EvenAndAbsLessThan100(number);

// Mostrar resultado
Console.WriteLine($"¿{number} es par y |valor| < 100?: {result}");