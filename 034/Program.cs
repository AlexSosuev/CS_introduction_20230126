// 34. Определить количество цифр в числе. Сделать подпрограмму

int CounterDigits(int k)
{
    if (k == 0) return 1;

    int counter = 0;
    while (k != 0)
    {
        counter++;
        k /= 10;
    }
    return counter;
}
System.Console.WriteLine(CounterDigits(0));