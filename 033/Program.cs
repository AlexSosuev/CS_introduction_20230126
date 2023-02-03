// 33.Возведите число А в натуральную степень B используя цикл
int exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

System.Console.Write("Введите число A и натуральную степень B: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(exponentiation(A, B));
