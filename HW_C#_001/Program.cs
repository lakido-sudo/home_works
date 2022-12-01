/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Задача 2");
int a = 5;
int b = 7;
int maxForTwoNum = a;

if (a > b) maxForTwoNum = a;
else maxForTwoNum = b;

Console.WriteLine("Максимальное число из двух чисел " + maxForTwoNum);

Console.WriteLine("Задача 4");
int d = 3;
int e = 1;
int f = 2;
int maxForThrNum = d;

if (d > e) maxForThrNum = d;
if (f > maxForThrNum) maxForThrNum = f;

Console.WriteLine("Максимальное число из трех чисел " + maxForThrNum);

Console.WriteLine("Задача 6");
int g = -3;
if (g % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Не четное");

Console.WriteLine("Задача 8");
int n = 5;

for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);








