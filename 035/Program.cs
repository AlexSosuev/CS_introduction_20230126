// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму
int sumOfDigits(int n)
{
    int result = 0;
    while (n != 0)
    {
        result += n % 10;
        n /= 10;
    }
    return result;
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Сумма цифр в числе n равна " + sumOfDigits(n));