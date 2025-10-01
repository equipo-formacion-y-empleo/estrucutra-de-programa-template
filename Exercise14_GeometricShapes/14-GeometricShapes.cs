double CalculateTriangleArea()
{
    throw new NotImplementedException();
}

double CalculateSquareArea()
{
    throw new NotImplementedException();
}

double CalculateHexagonArea()
{
    throw new NotImplementedException();
}

double side = double.Parse(args.Length > 0 ? args[0] : "10,0");

Console.WriteLine($"Triángulo Equilátero: área = {CalculateTriangleArea():F2}");
Console.WriteLine($"Cuadrado: área = {CalculateSquareArea():F2}");
Console.WriteLine($"Hexágono Regular: área = {CalculateHexagonArea():F2}");
