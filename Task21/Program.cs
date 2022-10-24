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

double Coord(string n, double coord)
{
    Console.WriteLine();
    Console.Write("Введите координаты точки: " + n + " = ");
    coord = Convert.ToDouble(Console.ReadLine());
    return coord;
}

double x1 = 0; double y1 = 0; double z1 = 0; double x2 = 0; double y2 = 0; double z2 = 0;

x1 = Coord("x1", x1);
y1 = Coord("y1", y1);
z1 = Coord("z1", z1);
x2 = Coord("x2", x2);
y2 = Coord("y2", y2);
z2 = Coord("z2", z2);

double res = Distance3D(x1, y1, x2, y2, z1, z2);
Console.WriteLine();
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно =  {res}");
Console.WriteLine();