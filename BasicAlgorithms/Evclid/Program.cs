int a = 75, b = 35;
int a1 = a, b1 = b;
while (a != b)
{
    if (a > b) a -= b;
    else b -= a;
}
System.Console.WriteLine("НОД - " + a);
System.Console.WriteLine("НОК - " + (a1 * b1) / a);