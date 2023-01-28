// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rev = 0;
int chek = num;

while (num > 0)
{
    int rem = num % 10;
    rev = (rev * 10) + rem;
    num = num / 10;
}
Console.WriteLine($"Новое число --> {rev}");

if (chek == rev)
    {
        System.Console.WriteLine($"Ваше число ЯВЛЯЕТСЯ палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Ваше число НЕ является палиндромом");
    }

