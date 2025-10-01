using System;

double CalculateRestaurantBill(double subtotal, double taxPercentage, double tipPercentage, int numberOfDiners)
{
    throw new NotImplementedException();
}

// Obtener argumentos de línea de comandos
double subtotal = double.Parse(args.Length > 0 ? args[0] : "100,0");
double taxPercentage = double.Parse(args.Length > 1 ? args[1] : "0,21");
double tipPercentage = double.Parse(args.Length > 2 ? args[2] : "0,15");
int numberOfDiners = int.Parse(args.Length > 3 ? args[3] : "4");

// Calcular total por persona
double totalPerPerson = CalculateRestaurantBill(subtotal, taxPercentage, tipPercentage, numberOfDiners);

// Mostrar resultado
Console.WriteLine($"Total por persona: €{totalPerPerson:F2}");
