// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



// Решение 1

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - не является пятизначным");
// }


// решение 2


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int a1 = number / 10000;
    int b1 = number % 10;
    if (a1 == b1)
    {
        number = number / 10;
        int a2 = number % 10;
        int b2 = (number / 100) % 10;

        if (a2 == b2)

            Console.WriteLine("палиндромом");
    }

    else
    {
        Console.WriteLine("Не палиндромом");
    }


}
else
{
    Console.WriteLine("Не пятизначное число!");
}