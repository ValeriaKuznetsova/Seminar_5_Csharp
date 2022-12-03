// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int[] CreateRandomArray(int N, int start, int end) //готовая функция рандом массива
{
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
array[i] = new Random().Next(start, end + 1);
}
return array;
}

void ShowArray(int[] array) //функция вывода массива
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of start filling array by random numbers by three digit min"); //введите трёхзначное число для нижнего диапазона массива
int min = Convert.ToInt32(Console.ReadLine());

if (min < 100 || min > 999) //проверка на трёхзначность
{
do
{
Console.WriteLine ("Wrong number!Enter the number from 100 to 999: ");
Int32.TryParse(Console.ReadLine(), out min);
} while (min < 100 || min > 999);
}
Console.WriteLine("Enter the number of end filling array by random numbers by three digit max"); //введите трёхзначное число для верхнего диапазона массива
int max = Convert.ToInt32(Console.ReadLine());

if (max < 100 || max > 999) //проверка на трёхзначность
{
do
{
Console.WriteLine ("Wrong number!Enter the number from 100 to 999: ");
Int32.TryParse(Console.ReadLine(), out max);
} while (max < 100 || max > 999);
}
int[] array = CreateRandomArray(num, min, max);

ShowArray(array);

int count = 0;

for ( int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count++;
}
Console.WriteLine($"Summ of even numbers in the array is: {count}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int N, int start, int end) //готовая функция рандом массива
// {
// int[] array = new int[N];
// for (int i = 0; i < N; i++)
// {
// array[i] = new Random().Next(start, end + 1);
// }
// return array;
// }

// void ShowArray(int[] array) //функция вывода массива
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }
// int[] array = CreateRandomArray(5, 10, 100);

// ShowArray(array);

// int summOddIndx = 0;

// for ( int i = 0; i < array.Length; i++)
// {
// if ( i % 2 != 0)
// summOddIndx += array[i];
// }
// Console.WriteLine($"Summ of numbers at Odd indexes in the array is: {summOddIndx}");