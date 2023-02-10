// Задача 27. Напишите программу, которая принимает на вход число и выдает
// сумму цифр в числе.
/*
int sumDig(int n)
{
    int sum;
    sum = n % 10;
    if( n >= 10)
    {
        sum += sumDig(n / 10);
    }
    return sum;
} 
Console.Write("Iput n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumDig(n));
*/
// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и 
// возводит число А в натуральную степень В.
/*
int ReadInt(string messager)
{
    Console.WriteLine(messager);
    return Convert.ToInt32(Console.ReadLine());

}

int a = ReadInt("Input value a: ");
int b = ReadInt("Input value b: ");
ToDegree(a, b);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

*/

// Задача 29. Напишите программу, которая задает массив из M элементов и 
// выводит их на экран.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;

} 
*/

int[] CreateRandomArray(int value);

void ShowArray(int[] array)
{
    for(int i = 0; i <= array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}
//Console.Write("Input a length of new array: ");
//int length = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a min possible value: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a max possible value: ");
//int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value: ");
int value = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(value);
ShowArray(myArray);














/*
int ReadInt(string messager)
{
    Console.WriteLine(messager);
    return Convert.ToInt32(Console.ReadLine());
}

int lenArray = ReadInt("Input a length array: ");

int[] randomArray = new int[lenArray];
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1,9);
        Console.Write(randomArray[i] + " ");
    }      
}
*/


