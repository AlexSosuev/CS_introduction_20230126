// Используя циклы вывести числа от 1 до N.
//int N = 10, i = 0;
// while (i < N)
//     System.Console.Write($"{++i,4}");
// System.Console.WriteLine();

//Запрещено!!!
// i = 0;
// metka:
// System.Console.Write($"{++i,4}");
// if (i < N) goto metka; //оператор безусловного перехода
// System.Console.WriteLine();

// Неиспользуя циклы ...
void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i < N) Loop(i + 1, N);//рекурсия
}

Loop(1, 20);
System.Console.WriteLine();

//Вычисление факториала
int F(int N)
{
    if (N > 0) return F(N - 1) * N;
    else return 1;
}

System.Console.WriteLine($"Факториал 5 равен {F(5)}");
//Числа фиббоначи
int Fibb(int N)
{
    if (N == 0) return 0;
    else
        if (N == 1) return 1;
    else
        return Fibb(N - 1) + Fibb(N - 2);
}

for (int j = 0; j < 20; j++)
    System.Console.Write($"{Fibb(j)} ");
System.Console.WriteLine();

//Возвести a в степень b
double Power(int a, int b)
{
    if (b == 0) return 1;
    else if (b > 0) return Power(a, b - 1) * a;
    else return Power(a, b + 1) / a;
}

for (int j = -10; j < 0; j++)
    System.Console.Write($"{Power(2, j)} ");
System.Console.WriteLine();