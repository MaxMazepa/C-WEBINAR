// // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Укажите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2 & num1>num3) 
{
    Console.WriteLine($"Наибольшее число: {num1}");
} 
else
{
    if (num2>num3)
    {
        Console.WriteLine($"Наибольшее число: {num2}");
    }
    else
    {
        Console.WriteLine($"Наибольшее число: {num3}");
    }
}