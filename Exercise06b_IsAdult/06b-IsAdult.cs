bool IsAdult(int age)
{
    throw new NotImplementedException();
}

int age = int.Parse(args.Length > 0 ? args[0] : "20");

Console.WriteLine($"¿Es {age} años adulto? {IsAdult(age)}");