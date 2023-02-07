// 48. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. Создайте массив, который является 
//произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
System.Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();

int[] arr=new int[N/2];
for(int i=0; i<a.Length/2;i++) 
    arr[i]=a[i]*a[a.Length-i-1];

for(int i=0; i<arr.Length;i++)
    System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();