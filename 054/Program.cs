// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr=new int[N];
CreateFibonacci(N,arr);
PrintArray(arr);

void CreateFibonacci(int N, int[] arr){    
    arr[0]=0;
    arr[1]=1;
    for (int i = 2; i < N;i++){
        arr[i]=arr[i-2]+arr[i-1];
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.Write($"{arr[i]} ");
}