//Программа, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

string Palindrom(string n)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
       return "является";
    }
    else
    {
        return "не является";
    }
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
    string res = Palindrom(Convert.ToString(number));
    Console.WriteLine();
    Console.WriteLine($"Число {number} {res} палиндромом");
    Console.WriteLine();
}