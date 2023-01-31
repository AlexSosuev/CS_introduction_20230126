// 20. Дано число. Проверить кратно ли оно 7 и 23
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 7 == 0 && N % 23 == 0) System.Console.WriteLine($"Число {N} кратно 7 и 23");
else System.Console.WriteLine($"Число {N} не кратно 7 и 23");