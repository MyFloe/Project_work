// // Использование функций обязательно, начиная с этого ДЗ!

// // Задача 25: Напишите цикл, который принимает на вход два числа
// //  (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
Degree(numberA, numberB);


void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}


void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}




// Задача 29:
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]


int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}




// Задача 29: Напишите программу, которая задаёт массив из 8
// целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int elCount = 8;
int[] myArray = new int[elCount];

for (int i=0; i<myArray.Length; i++)
  {
    Console.Write($"введите элемент массива {i+1}: ");
    myArray[i]=int.Parse(Console.ReadLine());   
  }
  Console.WriteLine("Вывод массива:");
  for (int i=0; i<myArray.Length; i++)
  {
    //Console.Write(myArray[i]);
    Console.Write($"{myArray[i]} ");
  }
  

// // Задача 27. - HARD необязательная Напишите программу, которая принимает
// // на вход целое или дробное число и выдаёт количество цифр в числе.
// // 452 -> 3
// // 82 -> 2
// // 9,012 ->4


