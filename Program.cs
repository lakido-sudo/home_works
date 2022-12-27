Console.WriteLine("Задача 47 ");
Console.WriteLine("Массив случайных вещественных чисел");

int m = 3;
int n = 4;

double[,] array = new double[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n ; j++)
    {
        array[i, j] = (random.NextDouble() * 2.0 - 1.0) * 10;
        Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("Задача 50");
Console.WriteLine("Массив 4х4");

int o = 4;
int p = 4;
int[,] array2 = new int[o, p];

for (int i = 0; i < array2.GetLength(0); i++) 
{
    for (int j = 0; j < array2.GetLength(1); j++)
        array2 [i, j] = Convert.ToInt32(new Random().Next(0,10));  
}

for (int i = 0; i < array2.GetLength(0); i++) 
{
    for (int j = 0; j < array2.GetLength(1); j++)
        Console.Write(array2[i,j] + "\t");
        Console.WriteLine();
}

Console.WriteLine("Введите координаты числа (индексы)");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a>=o && b>=p || a>=o && b<=p || a<=o && b>=p )
{
Console.WriteLine("По таким координатам в данном массиве нет числа");
}
else
{
object c = array2.GetValue(a,b);
Console.WriteLine($"По таким координатам в данном массиве число : {c}");
}

Console.WriteLine("Задача 52");

int[,] mas = new int[3,3] {{1,2,3},{4,5,6},{7,8,8}};

for (int i = 0; i < 3; i++) 
{
    int srAr = 0;
    for (int t = 0; t < 3; t++)
    {
        srAr += mas[i,t];
        Console.Write(mas[t, i] + "\t");
    }
Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3}");
}
