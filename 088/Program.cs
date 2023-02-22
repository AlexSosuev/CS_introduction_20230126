// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и 
//конечную строку.
string? st = Console.ReadLine();
Console.WriteLine($"Исходная строка: {st}"); 
Console.WriteLine("Конечная строка: {0}", st.Replace('w','v'));   