int? age = null;     // int tipi (nullable)
var name = "Ebrar";  // string tipi

Console.WriteLine("age değişkeninin tipi: " + age?.GetType());
Console.WriteLine("name değişkeninin tipi: " + name.GetType());

string? nullable = null;   // referans yok (NULLABLE STRING)
Console.WriteLine("Büyük harf : " + nullable?.ToUpper());
Console.WriteLine("Kullanıcı adı : " + (nullable ?? "Bilinmiyor."));
Console.WriteLine("Yaş: " + (age ?? -1));

Console.ReadKey();
