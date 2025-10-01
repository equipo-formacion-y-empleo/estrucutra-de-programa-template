bool IsNotNegative(int number)
{
    throw new NotImplementedException();
}

int number = int.Parse(args.Length > 0 ? args[0] : "0");

Console.WriteLine($"¿Es {number} no negativo? {IsNotNegative(number)}");