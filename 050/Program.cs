// 50. Выяснить являются ли три числа сторонами треугольника
int a = 4, b = 3, c = 4;
if (a + b > c && a + c > b && b + c > a)
    System.Console.WriteLine("Являются");
else System.Console.WriteLine("Не являются");