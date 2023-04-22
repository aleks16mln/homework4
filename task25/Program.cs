// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A : ");
int A = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
int i = 1;
while (i <= N)
{
    factorial = factorial * i;
    i++;
}

Console.WriteLine(factorial);