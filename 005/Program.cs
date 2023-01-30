// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.Write("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
if (a > max)
    max = a;
else if (b > max)
    max = b;
System.Console.WriteLine($"Максимальное из введенных чисел равно: {max}");
