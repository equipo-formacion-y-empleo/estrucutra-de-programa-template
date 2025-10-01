using System;

bool Between10And20OrEven(int number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 15;

// Probar la función
bool result = Between10And20OrEven(number);

// Mostrar resultado
Console.WriteLine($"¿{number} está entre 10-20 o es par?: {result}");