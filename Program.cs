//1
Console.WriteLine("Задача 34");
int[] array = new int[4];
Random rand = new Random();
int sumEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
    Console.WriteLine(array[i]);
    if ((array[i] % 2) == 0)
    {
        sumEven +=1;
    }
}

Console.WriteLine("Количество четных чисел в этом массиве: " + sumEven);

//2
Console.WriteLine("Задача 36");
int[] array2 = new int[4];
Random rand2 = new Random();
int sumNotEven = 0;

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = rand2.Next(100, 999);
    Console.WriteLine(array2[i]);
    if ((array2[i] % 2) == 1)
    {
        sumNotEven += 1;
    }
}

Console.WriteLine("Количество не четных чисел в этом массиве: " + sumNotEven);

//3
Console.WriteLine("Задача 38");
double[,] array3 = new double[4, 4];
Random random = new Random();

double minNumber = 100;
double maxNumber = array3[0,0];
 
for (int i = 0; i < 4; i++)
{
    
    for (int j = 0; j < 4; j++)
    {
        array3[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", array3[i, j]);

        if (maxNumber < array3[i,j])
        {
            maxNumber = array3[i,j];
        }
        if (minNumber > array3[i,j])
        {
            minNumber = array3[i,j];
        } 
    }
    Console.WriteLine();
}

double difference = maxNumber - minNumber;

Console.WriteLine("В этом массиве: ");
Console.WriteLine("Минимальное число"+"{0,6:F2}",minNumber);
Console.WriteLine("Максимальное число"+"{0,6:F2}",maxNumber);
Console.WriteLine($"Разница"+"{0,6:F2}",difference);
