bool IsWorkingAge(int age)
{
    throw new NotImplementedException();
}

int age = int.Parse(args.Length > 0 ? args[0] : "30");

// Mostrar resultado
Console.WriteLine($"¿Con {age} años se puede trabajar? {IsWorkingAge(age)}");