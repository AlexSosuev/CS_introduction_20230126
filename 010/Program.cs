// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{N % 10}");