// 78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. 
//Использовать рекурсию.

int Fibb(int N)
{
    if (N == 0) return 0;
    else
        if (N == 1) return 1;
    else
        return Fibb(N - 1) + Fibb(N - 2);
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
    System.Console.Write($"{Fibb(i)} ");
System.Console.WriteLine();
