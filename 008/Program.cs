// 8. Вывести на экран числа от -N до N
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while (i <= N)
{
    System.Console.WriteLine(i);
    i++;
}