// Дано число. Найти минимальную и максимальную цифру числа
int N = 12304;
int min = 10, max = -1;
while (N != 0)
{
    int digit = N % 10;
    if (digit > max) max = digit;
    if (digit < min) min = digit;
    N /= 10;
}
System.Console.WriteLine($"min={min} max={max}");