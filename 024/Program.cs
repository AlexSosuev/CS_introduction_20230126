// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.Write("Введите координаты точки: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0) System.Console.WriteLine("Не правильно введены координаты");
else if (x > 0 && y > 0) System.Console.WriteLine("Точка в 1-й четверти плоскости");
else if (x < 0 && y > 0) System.Console.WriteLine("Точка во 2-й четверти плоскости");
else if (x < 0 && y < 0) System.Console.WriteLine("Точка в 3-й четверти плоскости");
else if (x > 0 && y < 0) System.Console.WriteLine("Точка в 4-й четверти плоскости");