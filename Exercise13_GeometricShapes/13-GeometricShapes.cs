using System;

(double area, double perimeter) EquilateralTriangle(double side)
{
    throw new NotImplementedException();
}

(double area, double perimeter) Square(double side)
{
    throw new NotImplementedException();
}

(double area, double perimeter) RegularHexagon(double side)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
double side = double.Parse(args.Length > 0 ? args[0] : "5,0");

// Calcular figuras
var triangle = EquilateralTriangle(side);
var square = Square(side);
var hexagon = RegularHexagon(side);

// Mostrar resultados
Console.WriteLine($"Triángulo Equilátero: área = {triangle.area:F2}");
Console.WriteLine($"Cuadrado: área = {square.area:F2}");
Console.WriteLine($"Hexágono Regular: área = {hexagon.area:F2}");
