// Напишите подпрограмму нахождения расстояния между двумя точками
double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

double distance = Distance(0, 0, 2, 2);
System.Console.WriteLine(distance);