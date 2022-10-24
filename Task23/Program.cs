/*  Программа, которая принимает
    на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.Clear();

// Метод для нахождения таблицу кубов чисел от 1 до N.

void TableOfNumberInCube(int n)
{
    for (int i = 1; i <= n; i++)
    {
    int res = 1;
        for (int j = 1; j <= 3; j++)
        {
            res = res * i;
        }
    Console.WriteLine($"{i} ^ 3 = {res}");
    Console.WriteLine();
    }
}

Console.Write("Введите число, для которого получаем таблицу кубов:  ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

TableOfNumberInCube(N);