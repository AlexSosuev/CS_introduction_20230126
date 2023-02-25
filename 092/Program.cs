/* 93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] brr = { { 1, 5, 8, 5 }, { 4, 9, 4, 2 }, { 7, 2, 2, 6 }, { 2, 3, 4, 7 } };
Print2DArray(arr);
System.Console.WriteLine();
Print2DArray(brr);
System.Console.WriteLine();
int[,] crr = Multiplication(arr, brr);
Print2DArray(crr);

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

//Умножение матриц
int[,] Multiplication(int[,] arr, int[,] brr)
{
    if (arr.GetLength(0) != brr.GetLength(1)) throw new Exception("Матрицы нельзя перемножать");
    int[,] result = new int[arr.GetLength(0), brr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < brr.GetLength(1); j++)
            for (int k = 0; k < brr.GetLength(0); k++)
                result[i, j] += arr[i, k] * brr[k, j];
    return result;
}