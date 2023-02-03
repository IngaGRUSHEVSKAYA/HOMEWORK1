
// ДЗ. Задача 2. Напишите программу, которая на вход принимает два числа и
// выдает, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2)
{
    Console.WriteLine("num1 = max");
} 
else
{
    Console.WriteLine("num2 = max");
}
*/

//ДЗ. Задача 4. Напишите программу, которая принимает на вход три числа и
// выдает максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на 2 без остатка).
/*

int a;
Console.Write("a:");
a = int.Parse(Console.ReadLine());
if (a % 2 ==0)
{
    Console.Write("Введенное число является четным");
    Console.Read();
}
else
{
    Console.Write("Введенное число является нечетным");
    Console.Read();
}   
*/


//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе
//показывает все четные числа от 1 до N.
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int i;
i = 1;

while(i <=n)
{
    if(i % 2 ==0)
    {
        Console.Write(i + " ");
        i = i + 1;
    }
    else
    {
        i = i + 1;
    }
}
*/