// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FiellArrayRandomus(number);
Console.WriteLine("массив: ");
PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < number.Length; j++)
{
    if (number[j] > max)
    {
        max = number[j];
    }
    if (number[j] < min)
    {
        min = number[j];
    }
}

Console.WriteLine($"максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FiellArrayRandomus(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100, 10000))/100;
    }
}
void PrintArray(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    Console.WriteLine();
}
