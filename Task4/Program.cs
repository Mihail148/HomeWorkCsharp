// Задача №4 : Напишите программу, которая принимает на вход три числа и выдает максимальное их этих чисел.

Console.WriteLine("Введите 3 числа");
int numberA = Convert.ToInt16(Console.ReadLine());
int numberB = Convert.ToInt16(Console.ReadLine());
int numberC = Convert.ToInt16(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.WriteLine("Наибольшее из введенных чисел -> " + max);