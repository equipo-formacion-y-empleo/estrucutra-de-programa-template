bool IsWorkingAge(int age)
{
    throw new NotImplementedException();
}

int age = int.Parse(args.Length > 0 ? args[0] : "30");

Console.WriteLine($"¿Está {age} años en edad de trabajar? {IsWorkingAge(age)}");