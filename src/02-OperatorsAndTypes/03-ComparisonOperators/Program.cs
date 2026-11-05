Console.WriteLine("Enter Your First Number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Your Second Number:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} == {b} = {a == b}");
Console.WriteLine($"{a} != {b} = {a != b}");
Console.WriteLine($"{a} < {b}  = {a < b}");
Console.WriteLine($"{a} > {b}  = {a > b}");
Console.WriteLine($"{a} <= {b} = {a <= b}");
Console.WriteLine($"{a} >= {b} = {a >= b}");

Console.ReadKey();
