using System;

double CalculateTriangleArea(double side)
{
    throw new NotImplementedException();
}

double CalculateSquareArea(double side)
{
    throw new NotImplementedException();
}

double CalculateHexagonArea(double side)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
double side = double.Parse(args.Length > 0 ? args[0] : "5,0");

// Calcular figuras
double triangleArea = CalculateTriangleArea(side);
double squareArea = CalculateSquareArea(side);
double hexagonArea = CalculateHexagonArea(side);

// Mostrar resultados
Console.WriteLine($"Triángulo Equilátero: área = {triangleArea:F2}");
Console.WriteLine($"Cuadrado: área = {squareArea:F2}");
Console.WriteLine($"Hexágono Regular: área = {hexagonArea:F2}");
