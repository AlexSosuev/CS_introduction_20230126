// 56. Написать программу копирования массива
int[] arr = { 3, 2, 7, 1, 9, 8 };
System.Console.Write("Исходный массив: ");
PrintArray(arr); 
CopyArray_1(arr); 
CopyArray_2(arr);

void CopyArray_1(int[] arr){
    int[] brr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        brr[i]=arr[i]; 
    System.Console.Write("Скопированный массив (1-й способ): ");
    PrintArray(brr);
}
void CopyArray_2(int[] arr){
    int[] brr = new int[arr.Length];
    Array.Copy(arr, brr,arr.Length);
    System.Console.Write("Скопированный массив (2-й способ): ");
    PrintArray(brr);
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.Write($"{arr[i]} ");
    System.Console.WriteLine();
}