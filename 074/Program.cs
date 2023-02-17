// 74. Найти сумму цифр числа
int Sum(int n)
{
    if (n < 10) return n;
    else return n % 10 + Sum(n / 10);
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма цифр числа {n} равна {Sum(n)}");