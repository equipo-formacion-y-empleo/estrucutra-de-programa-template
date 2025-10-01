using System;

bool Between10And20OrEven(double number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
double number = args.Length > 0 ? double.Parse(args[0]) : 15.0;

// Probar la función
bool result = Between10And20OrEven(number);

// Mostrar resultado
Console.WriteLine($"¿{number} está entre 10-20 o es par? {result}");