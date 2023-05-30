// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



void PrintNumbersSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"сумма элементов от M до N = {sum}");
        return;
    }
    sum = sum + (m++);
    PrintNumbersSum(m, n, sum);
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbersSum(m, n, 0);