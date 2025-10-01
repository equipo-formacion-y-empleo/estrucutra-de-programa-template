using System;

bool ThirdBitActiveAndPositive(int number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 5;

// Probar la función
bool result = ThirdBitActiveAndPositive(number);

// Mostrar resultado
Console.WriteLine($"¿{number} tiene el tercer bit activo y es positivo? {result}");