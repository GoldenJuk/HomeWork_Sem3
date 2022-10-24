//Программа, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

string Palindrom(int n)
{
    string res;
    int a = n % 10;
    int b = n / 10000;
    int c = (n % 100) / 10;
    int d = (n % 10000) / 1000;

    if (a == b && c == d)
    {
        res = "является";
    }
    else
        res = "не является";
    return res;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine();
    Console.WriteLine("Отрицательное число не является палиндромом");
    Console.WriteLine();
}
else
if (number > 100000 || number < 10000)
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз");
    Console.WriteLine();
}
else
{
    string res = Palindrom(number);
    Console.WriteLine();
    Console.WriteLine($"Число {number} {res} палиндромом");
    Console.WriteLine();
}