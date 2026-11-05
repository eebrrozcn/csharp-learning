Console.WriteLine("Please enter your name:  ");
var name = Console.ReadLine();

Console.WriteLine("Merhaba, " + name + ".");
Console.WriteLine("Tipi: " + name?.GetType());

Console.ReadKey();
