//Подсчитать количество и сумму цифр
int N = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int sum = 0;
while (N != 0)
{
    counter++;
    int d = N % 10;
    sum += d;
    N /= 10;
}
System.Console.WriteLine(counter);
System.Console.WriteLine(sum);