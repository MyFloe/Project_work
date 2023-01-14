﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");

// int x = Convert.ToInt32(Console.ReadLine());
// int A = x/10000;
// int B = x%10;
// int a2 = x/1000/10;
// int b2 = x%100%10;
 
// if (A==B && a2==b2)
// {
//     Console.WriteLine("Число - палиндром");
// } 
// else
// {
//     Console.WriteLine("Число не является палиндромом");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координату х первой точки"); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату у первой точки"); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату z второй точки"); 
// int z1 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine("Введите координату х второй точки"); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату у второй точки"); 
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z второй точки"); 
// int z2 = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine(Dist(x1, y1, z1, x2, y2, z2)); 
 
 
// double Dist(int x1, int y1, int z1, int x2, int y2, int z2) 
// { 
//     double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
//     return D; 
// }




// Задача 23
// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}

// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.