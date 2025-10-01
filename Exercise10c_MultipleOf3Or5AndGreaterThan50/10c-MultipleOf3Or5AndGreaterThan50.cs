using System;

bool MultipleOf3Or5AndGreaterThan50(int number)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 55;

// Probar la función
bool result = MultipleOf3Or5AndGreaterThan50(number);

// Mostrar resultado
Console.WriteLine($"¿{number} es múltiplo de 3 o (5 y >50)? {result}");