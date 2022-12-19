//1
Console.WriteLine("Задача 25");
int A = 3;
int B = 5;

double powAinB = Math.Pow(A,B);
Console.WriteLine(powAinB);

//2
Console.WriteLine("Задача 27");
int C = 452;

int sumNumbersInC = 0;

while (C>0) 
{ 
sumNumbersInC = sumNumbersInC + (C % 10); 
C =  C/10; 
} 
Console.WriteLine(sumNumbersInC);

//3
Console.WriteLine("Задача 29");
int[] array = new int[8]{1,2,3,4,5,6,7,8};
Array.ForEach(array,Console.WriteLine);

