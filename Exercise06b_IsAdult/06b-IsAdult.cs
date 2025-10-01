bool IsAdult(int age)
{
    throw new NotImplementedException();
}

int age = int.Parse(args.Length > 0 ? args[0] : "20");

// Mostrar resultado
Console.WriteLine($"¿Si tienes {age} años eres mayor de edad? {IsAdult(age)}");