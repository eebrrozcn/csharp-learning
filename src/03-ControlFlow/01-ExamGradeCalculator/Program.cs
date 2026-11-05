Console.WriteLine("Midterm Grade: ");
double midterm = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Final Exam Grade: ");
double finalExam = Convert.ToDouble(Console.ReadLine());

var finalGrade = (midterm * 0.4) + (finalExam * 0.6);
Console.WriteLine($"Final Grade: {finalGrade}");

if (finalGrade >= 50 && finalExam >= 50)
    Console.WriteLine("Geçtiniz! (Passed)");
else
    Console.WriteLine("Kaldınız:) (Failed)");

Console.ReadKey();
