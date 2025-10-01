float CalculateHypotenuse(float side1, float side2)
{
    throw new NotImplementedException();
}

float side1 = float.Parse(args.Length > 0 ? args[0] : "3,0");
float side2 = float.Parse(args.Length > 1 ? args[1] : "4,0");

Console.WriteLine($"Hypotenuse: {CalculateHypotenuse(side1, side2)}");