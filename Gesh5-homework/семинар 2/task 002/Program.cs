// напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет

// // 645 -5
// // 78 - третьей цифры нет
// // 6549549 - 4


Console.WriteLine("впишите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n3 (int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
return result;
}

if (n3 (number) == -1)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine($"Третья цифра - это {n3 (number)}");