/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Задача 10");
int a = Convert.ToInt32(456);
Console.WriteLine("Число " + a);
string stringNumberOfa = Convert.ToString(a);
Console.WriteLine("Вторая цифра этого числа " + stringNumberOfa[1]);

Console.WriteLine("Задача 13");
int b = Convert.ToInt32(645);
Console.WriteLine("Число " + b);
string stringNumberOfb = Convert.ToString(b);

if (stringNumberOfb.Length > 2)
{
  Console.WriteLine("Третья цифра этого числа " + stringNumberOfb[2]);
}
else {
  Console.WriteLine("У этого числа нет третьей цифры");
}

Console.WriteLine("Задача 15");
int numDay = Convert.ToInt32(7);

if (numDay == 6 || numDay == 7)
{
    Console.WriteLine("Да");
}
else if (numDay <= 0 || numDay > 7)
{
    Console.WriteLine("На неделе 7 дней");
}   
else 
{
    Console.WriteLine("нет");
}