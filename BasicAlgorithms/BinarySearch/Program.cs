// Бинарный поиск
int[] RandomIntArray(int N, int min, int max)
{
    int[] a = new int[N];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max + 1);
    return a;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.Write($"{arr[i],5} ");
}

int BinSearch(int[] arr, int find)
{
    int i;
    int left = 0;
    int rigth = arr.Length - 1;
    i = left + (rigth - left) / 2;
    while (arr[i] != find && left < rigth)
    {
        if (find > arr[i])
        {
            left = i + 1;
        }
        else
        {
            rigth = i;
        }
        i = left + (rigth - left) / 2;
    }
    if (arr[i] != find) return -1;
    else return i;
}
int f = 20;
int[] a = RandomIntArray(20, 0, 100);
PrintArray(a);
Array.Sort(a);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(BinSearch(a, f));