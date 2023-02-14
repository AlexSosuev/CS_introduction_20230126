﻿// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.
System.Console.Write("Введите m и n: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] a = Random2DArray(n,m,0,20);
Print2DArray(a);
ChangeElement(a);
System.Console.WriteLine();
Print2DArray(a);

//Создание и заполнение массива
int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}
//Распечатка массива
void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}

int[,] ChangeElement(int [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            if (i%2==0 && j%2==0)
                a[i, j] = (int)Math.Pow(a[i,j],2);
    return a;
}

