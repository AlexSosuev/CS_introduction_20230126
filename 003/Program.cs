// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них
System.Console.Write("Введите числа a и b: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a >= b)
    System.Console.WriteLine($"Максимальное из введенных чисел равно: {a}");
else
    System.Console.WriteLine($"Максимальное из введенных чисел равно: {b}");