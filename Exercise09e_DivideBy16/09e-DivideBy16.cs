using System;

int DivideBy16(int number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 64;

// Probar la función
int result = DivideBy16(number);

// Mostrar resultado
Console.WriteLine($"{number} dividido por 16 usando bits: {result}");