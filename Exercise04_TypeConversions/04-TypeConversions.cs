double DemoImplicitConversions()
{
    throw new NotImplementedException();
}

int DemoExplicitConversions()
{
    throw new NotImplementedException();
}


decimal originalValue = decimal.Parse(args.Length > 0 ? args[0] : "23.89");
int targetInt = int.Parse(args.Length > 1 ? args[1] : "17");

Console.WriteLine($"Conversión explícita a int: {DemoExplicitConversions()}");
Console.WriteLine($"Conversión implícita a double: {DemoImplicitConversions()}");
