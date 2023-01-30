// 9. Вывести на экран четные числа от 1 до N
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    System.Console.WriteLine(i);
    i += 2;
}
