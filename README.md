# 🚀 C# Öğrenme ve Geliştirme Deposu (C# Learning Journey)

Bu depo, **C#** ve **.NET** teknolojilerini temelden ileri seviyeye öğrenme sürecinde geliştirilen projeleri, pratikleri ve örnek uygulamaları içermektedir.

Tüm projeler modüler, temiz ve endüstri standardı bir klasör mimarisine (`src/`) sahip olup tek bir ana çözüm (`CSharpLearning.slnx`) altında toplanmıştır.

---

## 🗂️ Proje ve Klasör Mimarisi

```text
csharp-learning/
│
├── CSharpLearning.slnx                # Tüm projeleri tek tıkla açan ana Visual Studio çözümü
│
└── src/
    ├── 01-Fundamentals/               # Temel Kavramlar & C#'a Giriş
    │   ├── 01-HelloWorld/             # Konsola ilk metin yazdırma ve program yapısı
    │   ├── 02-Variables/              # Değişken tanımlama ve temel string işlemleri
    │   ├── 03-ConsoleIO/              # Konsoldan veri okuma (ReadLine) ve çıktı verme
    │   └── 04-NullAndNullable/        # Nullable tipler, null-coalescing (??) ve null-check (?.)
    │
    ├── 02-OperatorsAndTypes/          # Operatörler ve Veri Tipleri
    │   ├── 01-DataTypes/              # int, double, string, DateTime veri tipleri
    │   ├── 02-ArithmeticOperators/    # +, -, *, /, %, ++, -- ve tip dönüşümleri
    │   ├── 03-ComparisonOperators/    # ==, !=, <, >, <=, >= karşılaştırmaları
    │   └── 04-LogicalOperators/       # &&, ||, ! mantıksal operatörleri
    │
    └── 03-ControlFlow/                # Karar Yapıları ve Uygulamalar
        └── 01-ExamGradeCalculator/    # Vize-Final ortalaması ve geçme/kalma uygulaması
```

---

## 📚 Modüller ve Konu Başlıkları

### 1️⃣ Temel Kavramlar (`01-Fundamentals`)
* **[HelloWorld](src/01-Fundamentals/01-HelloWorld)**: C# programlama dilinin temel sözdizimi, `Console.WriteLine` ve ilk konsol çıktısı.
* **[Variables](src/01-Fundamentals/02-Variables)**: Temel değişken tanımlama prensipleri ve string birleştirme.
* **[ConsoleIO](src/01-Fundamentals/03-ConsoleIO)**: Kullanıcıdan `Console.ReadLine()` ile veri alma, tip denetimleri (`GetType()`).
* **[NullAndNullable](src/01-Fundamentals/04-NullAndNullable)**: Nullable değer türleri (`int?`, `string?`), Null Conditional (`?.`) ve Null Coalescing (`??`) operatörleri.

### 2️⃣ Operatörler ve Veri Tipleri (`02-OperatorsAndTypes`)
* **[DataTypes](src/02-OperatorsAndTypes/01-DataTypes)**: `int`, `double`, `string`, `DateTime` veri türleri ve değişken bildirimleri.
* **[ArithmeticOperators](src/02-OperatorsAndTypes/02-ArithmeticOperators)**: Dört işlem, mod alma (`%`), artırma/azaltma (`++`, `--`) ve float/double casting.
* **[ComparisonOperators](src/02-OperatorsAndTypes/03-ComparisonOperators)**: Değerlerin eşitlik, büyüklük ve küçüklük durumlarının karşılaştırılması.
* **[LogicalOperators](src/02-OperatorsAndTypes/04-LogicalOperators)**: Mantıksal VE (`&&`), VEYA (`||`) operatörleri ile ehliyet alma uygunluk kontrolü.

### 3️⃣ Karar Yapıları ve Uygulamalar (`03-ControlFlow`)
* **[ExamGradeCalculator](src/03-ControlFlow/01-ExamGradeCalculator)**: Vize (%40) ve Final (%60) ağırlıklı not ortalaması hesaplayarak `if-else` koşuluyla ders geçme/kalma durumunu belirleyen interaktif konsol uygulaması.

---

## 🛠️ Teknolojiler ve Gereksinimler

* **.NET SDK:** .NET 10 (veya uyumlu sürüm)
* **Programlama Dili:** C# 13+
* **IDE / Editör:** Visual Studio 2022+ / Visual Studio Code / JetBrains Rider

---

## 💻 Nasıl Çalıştırılır?

Tüm projeleri tek komutla derlemek için:
```bash
dotnet build CSharpLearning.slnx
```

İstediğiniz herhangi bir projeyi doğrudan çalıştırmak için:
```bash
# Örnek 1: Not hesaplama uygulamasını çalıştırma
dotnet run --project "src/03-ControlFlow/01-ExamGradeCalculator"

# Örnek 2: Nullable tipler projesini çalıştırma
dotnet run --project "src/01-Fundamentals/04-NullAndNullable"

# Örnek 3: Mantıksal operatörler projesini çalıştırma
dotnet run --project "src/02-OperatorsAndTypes/04-LogicalOperators"
```

---

## 👤 Geliştirici

- **GitHub:** [@eebrrozcn](https://github.com/eebrrozcn)
