// 70. Показать натуральные числа от 1 до N, N задано
string NatChislo(int n)
{
    if (n == 1) return "1";
    else return NatChislo(n - 1) + " " + n;
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NatChislo(n));