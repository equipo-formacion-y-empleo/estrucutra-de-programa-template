using System;

int MultiplyByFour(int number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 7;

// Probar la función
int result = MultiplyByFour(number);

// Mostrar resultado
Console.WriteLine($"{number} multiplicado por 4 usando bits: {result}");