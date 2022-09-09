﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int[] Cube(int arg)
{   
    int i = 1;
    int[] res = new int [arg];
    while (i <= arg)
    {
        res[i-1] = (int) Math.Pow(i, 3);
        i++;
    }
    return res;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

System.Console.WriteLine("Введите число");
int input = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Ваше число: {input}");
PrintArray(Cube(input));
