bool EqualGroups(int totalElements, int groupSize)
{
    throw new NotImplementedException();
}

int totalElements = int.Parse(args.Length > 0 ? args[0] : "20");
int groupSize = int.Parse(args.Length > 1 ? args[1] : "5");

Console.WriteLine($"¿{totalElements} se puede dividir en grupos de {groupSize}? {EqualGroups(totalElements, groupSize)}");