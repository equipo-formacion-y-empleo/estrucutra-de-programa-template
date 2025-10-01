double ConvertTemperatures()
{
    throw new NotImplementedException();
}

double celsius = double.Parse(args.Length > 0 ? args[0] : "25");

Console.WriteLine($"{ConvertTemperatures():F2}°F");