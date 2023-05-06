// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray2D(int[,] array) // Заполнение массива рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2D(int[,] array) // вывод массива
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

void PrintArray(double[] array)
{
    Console.Write($"среднее арифметическое = ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}



int rows = ReadInt("Введите количество строк: "); // метод ввода 
int colums = ReadInt("Введите количество столбцов: "); // метод ввода 
int[,] number = new int[rows, colums];
FillArray2D(number); //метод заполнения массива рандомными вещественными числами
PrintArray2D(number); // метод вывод массива

double[] ArithmeticMean = new double[number.GetLength(1)];

for (int i = 0; i < number.GetLength(1); i++)
{
    double result =  0.0;
    for (int j = 0; j < number.GetLength(0); j++)
    {
        result += number[j, i];
    }
    ArithmeticMean[i] = result / number.GetLength(0);
}

PrintArray(ArithmeticMean);

