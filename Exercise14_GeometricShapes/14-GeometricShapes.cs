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

double side = double.Parse(args.Length > 0 ? args[0] : "10.0");

Console.WriteLine($"Triángulo Equilátero: lado = {side:F2}, área = {CalculateTriangleArea():F2}");
Console.WriteLine($"Cuadrado: lado = {side:F2}, área = {CalculateSquareArea():F2}");
Console.WriteLine($"Hexágono Regular: lado = {side:F2}, área = {CalculateHexagonArea():F2}");
