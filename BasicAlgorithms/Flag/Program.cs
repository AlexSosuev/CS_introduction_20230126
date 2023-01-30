// Дано число. Проверить, есть в этом числе 0?
int N = 1234;
bool flag = false;
while (N != 0)
{
    int d = N % 10;
    if (d == 0)
        flag = true;
    N /= 10;
}
if (flag)
    System.Console.WriteLine("В числеесть 0");
else
    System.Console.WriteLine("В числе нет 0");