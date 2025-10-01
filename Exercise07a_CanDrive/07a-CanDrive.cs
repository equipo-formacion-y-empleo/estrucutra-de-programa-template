bool CanDrive(int age, bool hasLicense)
{
    throw new NotImplementedException();
}

bool IsAdult(int age)
{
    throw new NotImplementedException();
}

int age = int.Parse(args.Length > 0 ? args[0] : "20");
bool hasLicense = bool.Parse(args.Length > 1 ? args[1] : "true");

Console.WriteLine($"¿Puede conducir ({age}, {hasLicense})? {CanDrive(age, hasLicense)}");