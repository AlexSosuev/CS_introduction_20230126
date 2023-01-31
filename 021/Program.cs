// 21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7) System.Console.WriteLine("Выходной");
else
    if (day >= 1 && day <= 5) System.Console.WriteLine("Рабочий день");
else
    System.Console.WriteLine("Это не день недели");