// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray2D(int[,] array) //метод заполнения массива рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10) ;
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


int rows = ReadInt("Введите индекс строки: "); // метод ввода 
int colums = ReadInt("Введите индекс столбца: "); // метод ввода 
int[,] number = new int[10,10];
FillArray2D(number); //метод заполнения массива рандомными числами
PrintArray2D(number); // метод вывода массива

if (rows < number.GetLength(0) && colums < number.GetLength(1)) Console.WriteLine($"в заданных позициях число = {number[rows, colums]}");
else Console.WriteLine($"числа с индексом строки {rows} и индексом столбца {colums} ->  нет");