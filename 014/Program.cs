// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b
System.Console.Write("Введите числа a и b: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
    System.Console.WriteLine($"число {a} кратно числу {b}");
else
    System.Console.WriteLine($"число {a} не кратно числу {b}, остаток от деления равен: {a % b}");