// принимает цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным

// 6 - да
// 7- да 
// 1 -нет

Console.WriteLine("впишите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
{
    Console.Write("к сожадениею, это не выходной");
}

else if (number >= 6 && number <= 7)
{
    Console.Write(" Да, это выходной");
}
else Console.Write(" Не существует такого дня недели");