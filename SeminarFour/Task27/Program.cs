// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = new Random().Next(111, 10000);
int sum = 0;
System.Console.WriteLine($"Исходное число --> {num}");

while (num/10 > 0)
{
    sum = sum + (num%10);
    num= num/10;
}
sum = sum + (num%10);
System.Console.WriteLine($"Сумма цифр числа -- > {sum}");

