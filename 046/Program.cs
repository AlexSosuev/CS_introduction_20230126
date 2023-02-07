// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] a=new int[123];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,1000);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int k=0;
for(int i=0;i<a.Length;i++)
    if(a[i]>=10 && a[i]<=99) k++;

System.Console.WriteLine($"Количество элементов из отрезка [10,99] - {k}");