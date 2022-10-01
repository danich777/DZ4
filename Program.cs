// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число А: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите натуральное число B: ");
// int num2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Число {num1} в степени {num2} = {GetPow(num1, num2)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе {number} = {GetSumm(number)}");

// int GetSumm (int num1)
// {
//     int result = 0;
//     while (number > 0)
//     {

//         result = result + number % 10;
//         number = number / 10;

//     }
// return result;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.


// int[] array = FillArray(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] FillArray(int size)
// {
//     int[] result =  new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(10);
//     }
// return result;
// }



//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Решение через цикл

Console.Write("Введите число А: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число B: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number1} в степени {number2} = {GetPow(number1, number2)}");

int GetPow(int num1, int num2)
{
    int num3=1;
    for (int i=1; i<=num2; i++)
       {
       num3 = num3*num1;
       }
return num3;
}

