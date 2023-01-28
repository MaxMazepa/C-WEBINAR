// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int two = num;

while (num >= 1000)
{
    num /= 10;
}
if (two / 100 < 1)
{
    System.Console.WriteLine($"Третьей цифры нет!");
}
else
{
    System.Console.WriteLine($"Третья цифра --> {num % 10}");
}