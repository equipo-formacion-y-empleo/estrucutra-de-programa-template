using System;

void SwapWithoutTemp(int a, int b)
{
    Console.WriteLine($"Antes: a={a}, b={b}");
    // TODO: Implementar el intercambio usando XOR
    throw new NotImplementedException();
    // Console.WriteLine($"Después: a={a}, b={b}");
}

// Obtener argumentos de línea de comandos
int a = args.Length > 0 ? int.Parse(args[0]) : 5;
int b = args.Length > 1 ? int.Parse(args[1]) : 3;

// Probar la función
SwapWithoutTemp(a, b);