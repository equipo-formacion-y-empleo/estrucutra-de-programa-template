double perPerson CalculateRestaurantBill()
{
    throw new NotImplementedException();
}

double subtotal = double.Parse(args.Length > 0 ? args[0] : "120.0");
double taxRate = double.Parse(args.Length > 1 ? args[1] : "0.21");
double tipRate = double.Parse(args.Length > 2 ? args[2] : "0.15");
int people = int.Parse(args.Length > 3 ? args[3] : "3");

Console.WriteLine($"Total por persona: €{CalculateRestaurantBill():F2}");
