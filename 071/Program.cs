// 71. Показать натуральные числа от N до 1, N задано
string NatChislo(int n)
{
    if (n == 1) return "1";
    else return n + " " + NatChislo(n - 1);
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NatChislo(n));
