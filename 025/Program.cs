// 25. Задать номер четверти, показать диапазоны для возможных координат
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter == 1) System.Console.WriteLine("x>0 and y>0");
else if (quarter == 2) System.Console.WriteLine("x<0 and y>0");
else if (quarter == 3) System.Console.WriteLine("x<0 and y<0");
else if (quarter == 4) System.Console.WriteLine("x>0 and y<0");
else System.Console.WriteLine("Нет такой четверти");