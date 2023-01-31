// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = new Random().Next(1, 10);
int B = new Random().Next(1, 10);
System.Console.WriteLine($"Результат --> {GetCycle(A,B)}");

static int GetCycle(int A, int B)
{
    System.Console.WriteLine($"Первое число(А) --> {A}");
    System.Console.WriteLine($"Второе число(В) --> {B}");
    int result = 1;

    for (int i = 1; i <= B; i++)
    {
        result = result * A;
        // result = Math.Pow(A, B);                  ((но так не сработало  ругается на int))
    }
    return result;
}

// System.Console.WriteLine($"Первое число(А) --> {A}");
// int B = new Random().Next(1, 10);
// System.Console.WriteLine($"Второе число(В) --> {B}");
// double result = 0;
                                                              // Вариант решения без метода
// for (int i = 1; i <= B; i++)
// {
//     result = Math.Pow(A, B);
// }
// System.Console.WriteLine($"Результат --> {result}");