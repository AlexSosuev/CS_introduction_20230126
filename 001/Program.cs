// 1. С клавиатуры вводится целое число. Вывести квадрат числа
checked
{
    System.Console.Write("Введите целое число: ");
    string? s = Console.ReadLine();
    int a = Convert.ToInt32(s);
    System.Console.WriteLine("Квадрат введенного числа: " + Math.Pow(a, 2));
}