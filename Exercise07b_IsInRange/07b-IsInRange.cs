bool IsInRange(int number, int minimum, int maximum)
{
    throw new NotImplementedException();
}

int number = int.Parse(args.Length > 0 ? args[0] : "15");
int minimum = int.Parse(args.Length > 1 ? args[1] : "10");
int maximum = int.Parse(args.Length > 2 ? args[2] : "20");

Console.WriteLine($"¿Está {number} en el rango [{minimum}, {maximum}]? {IsInRange(number, minimum, maximum)}");