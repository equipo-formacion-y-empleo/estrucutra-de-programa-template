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

double side = double.Parse(args.Length > 0 ? args[0] : "5,0");

var triangle = EquilateralTriangle(side);
var square = Square(side);
var hexagon = RegularHexagon(side);

Console.WriteLine($"Triángulo Equilátero: área = {triangle.area:F2}, perímetro = {triangle.perimeter:F2}");
Console.WriteLine($"Cuadrado: área = {square.area:F2}, perímetro = {square.perimeter:F2}");
Console.WriteLine($"Hexágono Regular: área = {hexagon.area:F2}, perímetro = {hexagon.perimeter:F2}");