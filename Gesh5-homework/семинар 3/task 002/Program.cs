// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Расстояние между двумя точками в трехмерном пространстве
// (Хb – Xa)^2 + (Yb – Ya)^2 + (Zb – Za)^2

Console.WriteLine("введите Xa ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Ya ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Za ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Xb ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Yb ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Zb ");
int Z2 = Convert.ToInt32(Console.ReadLine());


Console.Write(Math.Round(Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2)+ Math.Pow((Z2-Z1),2)) ,2));
Console.Write (" - растояние между точками а и b в 3D пространстве");