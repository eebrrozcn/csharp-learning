// Toplama
int sum = 5 + 3;
Console.WriteLine($"Toplam: {sum}");

// Çıkarma
int a = 5;
int b = 3;
Console.WriteLine($"Fark: {a} - {b} = {a - b}");

// Çarpma
int c = a * b;
Console.WriteLine($"Çarpım: {a} * {b} = {c}");

// Bölme
int d = a / b;
var e = (double)a / b;
Console.WriteLine($"d değerinin tipi: {d.GetType()} ");
Console.WriteLine($"e değerinin tipi: {e.GetType()} ");
Console.WriteLine($"Bölüm: {a} / {b} = {d}");
Console.WriteLine($"Ondalıklı bölüm: {a} / {b} = {e} ");

// Mod (Kalan)
int f = a % b;
Console.WriteLine($"Kalan: {a} % {b} = {f}");

// Arttırma ve Azaltma
int increase = 5;
increase++;

int decrease = 5;
decrease--;

Console.ReadKey();
