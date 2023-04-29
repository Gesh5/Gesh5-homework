// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int e=1; e<=N; e++)
{
if (e % 2 == 0)
System.Console.Write(e + ",");
}

Console.WriteLine("четные числа выведены");