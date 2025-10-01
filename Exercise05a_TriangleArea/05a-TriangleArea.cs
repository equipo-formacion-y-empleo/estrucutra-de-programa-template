double CalculateTriangleArea()
{
    throw new NotImplementedException();
}

double triangleBase = double.Parse(args.Length > 0 ? args[0] : "6.0");
double triangleHeight = double.Parse(args.Length > 1 ? args[1] : "4.0");

Console.WriteLine($"Área del triángulo: {CalculateTriangleArea():F2}");
