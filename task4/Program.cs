//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int numberA = new Random().Next(1, 1000);
Console.WriteLine("первое число: " + numberA);
int numberB = new Random().Next(1, 1000);
Console.WriteLine("второе число: " + numberB);
int numberC = new Random().Next(1, 1000);
Console.WriteLine("второе число: " + numberC);

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);
