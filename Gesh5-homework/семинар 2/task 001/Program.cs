// напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает вторую цифру этого числа

// 456 -5
// 782 -8
// 918 -1

Console.WriteLine("впишите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n2 = number % 100;

Console.WriteLine(number);
Console.WriteLine(n2 / 10);