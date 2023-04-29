// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
FillArrayRandomNumbers(number);
Console.Write("массив: ");
PrintArray(number);
int sum = 0;

for (int j = 1; j < number.Length; j+=2)
sum = sum + number[j];

Console.WriteLine ($"всего позиций {number.Length}, сумма чисел на четных позициях = {sum}");


void FillArrayRandomNumbers(int[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = new Random().Next(1,100);
        }
}
 void PrintArray(int[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.WriteLine();
}
