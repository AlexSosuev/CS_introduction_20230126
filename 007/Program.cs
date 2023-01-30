// 7. Выяснить, является ли число чётным?
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
bool odd = N % 2 == 0;
if (odd == true)
    System.Console.WriteLine($"Число {N} чётное");
else
    System.Console.WriteLine($"Число {N} не чётное");