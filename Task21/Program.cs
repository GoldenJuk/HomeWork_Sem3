/*  Программа, которая принимает на вход
    координаты двух точек и находит расстояние
    между ними в 3D пространстве
*/

Console.Clear();

//Метод для расчета расстояния между 2-мя точками в 3D пространстве

double Distance3D(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 -z1 ,2));
    return res;
}

//Метод для запроса координат точек

void Coord(string n)
{
    Console.WriteLine();
    Console.Write("Введите координаты точки: " + n + " = ");
}

string n;
Coord("x1");
double x1 = Convert.ToDouble(Console.ReadLine());

Coord("y1");
double y1 = Convert.ToDouble(Console.ReadLine());

Coord("z1");
double z1 = Convert.ToDouble(Console.ReadLine());

Coord("x2");
double x2 = Convert.ToDouble(Console.ReadLine());

Coord("y2");
double y2 = Convert.ToDouble(Console.ReadLine());

Coord("z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double res = Distance3D(x1, y1, x2, y2, z1, z2);
Console.WriteLine();
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно =  {res}");
Console.WriteLine();