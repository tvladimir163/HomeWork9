﻿Console.Clear();

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные
// числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberA < numberB)
// {
//     for (int i = 0; i < numberB; i++)
//     {
//         Console.Write($"{numberA} ");
//         numberA++;
//     }
// }
// else if (numberA > numberB)
// {
//     for (int j = numberB; j <= numberA; numberA--)
//     {
//         Console.Write($"{numberA} ");
//     }
// }




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = numberA; i <= numberB; i++)
// {
//     sum = sum + i;
// }
// Console.Write($"Сумма чисел в промежутке от {numberA} до {numberB} равна: {sum} ");




Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}