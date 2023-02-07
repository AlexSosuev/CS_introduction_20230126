// 45. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] a=new int[8];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int chet=0, neChet=0;
for(int i=0;i<a.Length;i++)
    if (a[i]%2==0) chet++;
    else neChet++;

System.Console.WriteLine($"Четных - {chet}, нечетных - {neChet}");
