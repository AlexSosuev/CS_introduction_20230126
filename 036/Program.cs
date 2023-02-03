// 36. Написать программу вычисления произведения чисел от 1 до N
int multiOfDigits(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Произведение чисел от 1 до n равно " + multiOfDigits(n));