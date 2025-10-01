bool AreDifferent(int num1, int num2, int num3)
{
    throw new NotImplementedException();
}

int num1 = int.Parse(args.Length > 0 ? args[0] : "5");
int num2 = int.Parse(args.Length > 1 ? args[1] : "1");
int num3 = int.Parse(args.Length > 2 ? args[2] : "3");

Console.WriteLine($"¿Son {num1}, {num2} y {num3} diferentes? {AreDifferent(num1, num2, num3)}");