Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Do you have a medical report? (true/false veya evet/hayir):");
string reportInput = Console.ReadLine()?.Trim().ToLower() ?? "";
bool hasHealthReport = reportInput == "true" || reportInput == "evet";

if (age >= 18 && hasHealthReport)
{
    Console.WriteLine("You can get a driver's license.");
}
else
{
    Console.WriteLine("You do not meet the requirements for obtaining a driver's license.");
}

if (age >= 18 || hasHealthReport)
{
    Console.WriteLine("You meet at least one of the conditions.");
}
else
{
    Console.WriteLine("You do not meet any of the conditions.");
}

Console.ReadKey();
