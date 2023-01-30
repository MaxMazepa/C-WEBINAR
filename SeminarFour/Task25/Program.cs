// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= B)
{
   int num = A*A;
    i++;
    System.Console.WriteLine(num);
}

// for (int i = 0; i <= B; i++)
// {
  
// }