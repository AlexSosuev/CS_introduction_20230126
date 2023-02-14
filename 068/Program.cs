// 68. Написать программу, которая обменивает элементы первой строки и последней строки
System.Console.Write("Введите m и n: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] a = Random2DArray(n,m,0,20);
Print2DArray(a);
ChangeElements(a);
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

int[,] ChangeElements(int [,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int temp=a[0,j];
        a[0,j]=a[a.GetLength(0)-1,j];
        a[a.GetLength(0)-1,j]=temp;
    }
    return a;
}