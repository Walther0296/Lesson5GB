// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача №1");
int[] array = new int[12];
int count = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
    Console.Write($" {array[i]}");
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {count}.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача №2");
int[] array1 = new int[12];
int sum = 0;
Console.Write("[");
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(1, 100);
    if (array1[i] % 2 == 1)
    {
        sum = sum + array1[i];
    }
    Console.Write($" {array1[i]}");
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"Сумма всех нечетных чисел в массиве: {sum}.");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Задача №3");
double[] array3 = new double[12];

double min = 0.00;
double max = 0.00;
Console.Write("[");
for (int i = 0; i < array3.Length; i++)
{
    Random rand = new Random();
    array3[i] = rand.NextDouble() * 40 - 20;
    Console.Write("{0:0.00} ", array3[i]);

    if (array3[i] < min)
    {
        min = array3[i];
    }

    if (array3[i] > max)
    {
        max = array3[i];
    }
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Максимальное число в массиве: "+ "{0:0.00} ", max);
Console.WriteLine("Минимальное число в массиве: "+ "{0:0.00} ", min);
double divercity = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {divercity}.");