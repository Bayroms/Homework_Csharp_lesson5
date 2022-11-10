// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] arr = GetRandomArray(5, 100, 999);
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Amount of even numbers in array: " + count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] arr = GetRandomArray(4, 0, 100);
// int sum = 0;
// int size = arr.Length % 2 == 0 ? arr.Length - 1: arr.Length - 2;
// for (int i = 1; i < size; i+=2)
// {
//     sum = arr[i] + arr[i+2];
// }
// System.Console.WriteLine("Summ of number in not even position = " + sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] arr = GetDoubleRandomArray(5);
double min = arr[0];
double max = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    else if (arr[i] > max)
    {
        max = arr[i];
    }
}
double subtraction = max - min;
System.Console.WriteLine($"Difference between {max} & {min} = {subtraction}");









void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
int[] GetRandomArray(int size, int begin = 0, int last = 100)
{
int[] arr = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = random.Next(begin, last + 1);
}
Console.WriteLine(String.Join(",", arr));

return arr;

}
double[] GetDoubleRandomArray(int size)
{
double[] arr = new double[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = random.NextDouble() * 100;
}
Console.WriteLine(String.Join(", ", arr));

return arr;

}