//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int numberA = new Random().Next(1, 1000);
Console.WriteLine("первое число: "+numberA);
int numberB = new Random().Next(1, 1000); 
Console.WriteLine("второе число: "+numberB);

int max = numberA;
int min = numberB;

if (numberB > max)
{
    max = numberB;
    min = numberA;
}
else
{
    max = numberA;
    min = numberB;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.Write(min);