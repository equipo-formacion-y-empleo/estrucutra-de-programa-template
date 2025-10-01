float AverageThreeNumbers(float a, float b, float c)
{
    throw new NotImplementedException();
}

float num1 = float.Parse(args.Length > 0 ? args[0] : "10,0");
float num2 = float.Parse(args.Length > 1 ? args[1] : "20,0");
float num3 = float.Parse(args.Length > 2 ? args[2] : "30,0");

Console.WriteLine($"Average: {AverageThreeNumbers(num1, num2, num3)}");