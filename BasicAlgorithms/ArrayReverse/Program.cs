//Инверсия массива
// 3 2 7 1 9
// 9 1 7 2 3

int[] arr = { 3, 2, 7, 1, 9, 8 };
//int[] b = new int[arr.Length];
//Array.Copy(arr, b, arr.Length);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
System.Console.WriteLine();

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.Write($"{arr[i]} ");
}
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Swap(ref arr[i], ref arr[arr.Length - 1 - i]);
    }
}