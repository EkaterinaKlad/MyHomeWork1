/*
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} is a max");
}
else
{
    Console.WriteLine($"{num2} is a max");
}
*/

/*
// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"{num1} is a max");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"{num2} is a max");
}
else
{
    Console.WriteLine($"{num3} is a max");
}
*/

/*
// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even number");
}
else
{
    Console.WriteLine($"{number} is not even number");
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
{
    Console.WriteLine(current + " ");
    current = current + 2;
}
