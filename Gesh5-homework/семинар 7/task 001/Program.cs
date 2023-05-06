// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = new Random().Next(1, 5);
// int n = new Random().Next(1, 5);

// double[,] nums = new double[m, n];


// for (int i = 0; i < nums.GetLength(0); i++)
// {
//     for (int j = 0; j < nums.GetLength(1); j++)
//     {
//         nums[i,j] = new Random().Next(-10, 100) / 10.0;
//         Console.Write($"{nums[i, j]} ");
//     }
//     Console.WriteLine();
// }


// решение методами

// ------------------------------------------------------

void FillArray2D(double[,] array) // Заполнение массива рандомными вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10) / 10.0;
        }
    }
}


void PrintArray2D(double[,] array) // вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string index) // метод ввода 
{
    Console.Write(index);
    return Convert.ToInt32(Console.ReadLine());
}


int rows = ReadInt("Введите количество строк: "); // метод ввода 
int colums = ReadInt("Введите количество столбцов: "); // метод ввода 
double[,] number = new double[rows, colums];
FillArray2D(number); //метод заполнения массива рандомными вещественными числами
PrintArray2D(number); // метод вывод массива