bool IsEven(int number)
{
    throw new NotImplementedException();
}

int number = int.Parse(args.Length > 0 ? args[0] : "4");

Console.WriteLine($"¿Es {number} un número par? {IsEven(number)}");