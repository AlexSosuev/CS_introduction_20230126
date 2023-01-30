// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.Write("Введите числоиз  диапазона  [10, 99]: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = N / 10, b = N % 10;
if (a >= b)
    System.Console.WriteLine($"Максимальная цифра введенного числа равна: {a}");
else
    System.Console.WriteLine($"Максимальная цифра введенного числа равна: {b}");
