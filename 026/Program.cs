// 26. Программа проверяет пятизначное число на палиндромом
System.Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a1 = n % 10;
int a2 = n / 10000;
int b1 = n % 100 / 10;
int b2 = n / 1000 % 10;
if (a1 == a2 && b1 == b2) System.Console.WriteLine("Полиндром");
else System.Console.WriteLine("Не полиндром");