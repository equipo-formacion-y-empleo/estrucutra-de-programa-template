float totalSurface = 0;

double CalculateRectangleAreas(double width, double height)
{
    throw new NotImplementedException();
}

double area1 = CalculateRectangleAreas(double.Parse(args.Length > 0 ? args[0] : "3"), double.Parse(args.Length > 1 ? args[1] : "4"));
double area2 = CalculateRectangleAreas(double.Parse(args.Length > 2 ? args[2] : "5"), double.Parse(args.Length > 3 ? args[3] : "6"));
Console.WriteLine($"Suma total de superficies: {totalSurface}");