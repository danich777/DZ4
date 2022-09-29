// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число А: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите натуральное число B: ");
// int num2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Число {num1} в степени {num2} = {GetPow(num1, num2)}");

// double GetPow(int number1, int number2)
// {
//     double result = Math.Pow(number1, number2);

//     return result;
// }



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


int[] array = FillArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] FillArray(int size)
{
    int[] result =  new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10);
    }
return result;
}

