// 88. Заменить все вхождения подстроки w в строке st на строку v. Вывести на экран первоначальную строку и 
//конечную строку.
using System.Text;
string st = Console.ReadLine();
System.Console.WriteLine($"Исходная строка: {st}"); 
StringBuilder st1 = new StringBuilder(st);
for(int i=0;i<st1.Length;i++)
  if (st1[i]=='w') st1[i]='v';
System.Console.WriteLine($"Конечная строка: {st1}");   