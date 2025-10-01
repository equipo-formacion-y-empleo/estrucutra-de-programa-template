float CalculateBMI(float weight, float height)
{
    throw new NotImplementedException();
}

float weight = float.Parse(args.Length > 0 ? args[0] : "70");
float height = float.Parse(args.Length > 1 ? args[1] : "1,75");

Console.WriteLine($"BMI: {CalculateBMI(weight, height)}");