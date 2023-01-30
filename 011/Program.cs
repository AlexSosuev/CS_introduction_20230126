// 11. Дано число больше 9. Ввести на экран вторую цифру числа с конца
System.Console.Write("Введите число, больше 9: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{N / 10 % 10}");