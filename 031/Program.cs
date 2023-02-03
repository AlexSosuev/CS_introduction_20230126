// 31.Вывести на экран кубы чисел от 1 до N
int kubic(int n)
{
    return (int)Math.Pow(n, 3);
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine(kubic(i));
}