// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO)
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 100)
    System.Console.WriteLine($"Нет третьей цифры в введенном числе");
else
{
    while (N >= 1000)
        N /= 10;
    System.Console.WriteLine($"Третья цыфра введенного числа равна {N % 10}");
}