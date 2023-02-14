// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами
System.Console.Write("Введите m и n: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] a = Random2DArrayDouble(n,m,0,20);
Print2DArray(a);

//Создание и заполнение массива
double[,] Random2DArrayDouble(int N, int M, int min, int max)
{
    double[,] a = new double[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.NextDouble();
    return a;
}
//Распечатка массива
void Print2DArray(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6:F2}");
        System.Console.WriteLine();
    }
}
