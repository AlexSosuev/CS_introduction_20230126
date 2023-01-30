// 13. Удалить вторую цифру целого числа введенного с клавиатуры.
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
    System.Console.WriteLine($"Нет второй цифры в введенном числе");
else
{
    int k = 1, temp = N;
    while (temp >= 10)
    {
        k *= 10;
        temp /= 10;
    }
    if (k > 10)
        System.Console.WriteLine($"Новое число {N / k}{N % (k / 10)}");
    else
        System.Console.WriteLine($"Новое число {N / k}");
}
