
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}
/*
Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/
/*
int GetSumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}
/*
Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int sumofNegatives = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negatives is " + sumofNegatives);
*/

//Задача 34. Задайте массив, заполненный случайными положительными трехзначными
// числами. Напишите программу, которая покажет количество четных чисел.
/*
void PositivArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
       
    }
    Console.WriteLine($"{count} an even number");
}
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] myArray = CreateRandomArray(size, 100, 999);
ShowArray(myArray);
PositivArray(myArray);
*/




//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечетных позициях.
/*
void RandomNumbersArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
       sum = sum + array[i];
    }
    Console.WriteLine($"{sum} the amount elements in odd positions");
}
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] myArray = CreateRandomArray(size, -10, 100);
ShowArray(myArray);
RandomNumbersArray(myArray);
*/


// Задача 38. Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
/*
double min = Int32.MaxValue;
double max = Int32.MinValue;
void DoubleArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            {
                max = array[i];
            }
        if(array[i] < min)
            {
                min = array[i];
            }
    }
    Console.WriteLine($"maxValue = {max}, minValue = {min}");
    Console.WriteLine($"difference = {max - min}");
}
Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
int[] myArray = CreateRandomArray(size, 1, 100);
ShowArray(myArray);
DoubleArray(myArray);
*/
