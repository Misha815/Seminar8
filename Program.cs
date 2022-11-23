/* Задание 54 - Задайте двумерный массив. Напишите программу, которая порядочит элементы
каждой строки двумерного массива. */    
    
 /*    Console.Write("input rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input colum: ");
        int colum = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colum];

Create2DArray(array);
Print2DArray(array);

void Create2DArray (int[,] arrayC)
{
Console.Write("input min ");
    int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max ");
    int max = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
             arrayC[i,j] = new Random().Next(min,max);
        }
    }
    
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sort2DArray (int[,] arrayS)
{
    
    for (int i = 0; i < arrayS.GetLength(0); i++)
    {
         for (int j = 0; j < arrayS.GetLength(1); j++)
        {
           for (int k = 0; k < arrayS.GetLength(1) - 1; k++)
           {
            if (arrayS[i,k] < arrayS[i,k+ 1])
            {
                int temp = arrayS[i,k + 1];
                arrayS[i,k + 1] = arrayS[i,k];
                arrayS[i,k] = temp;
            }
           }
        }
    }
  
}

Sort2DArray(array);
Print2DArray(array);
 */

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


/* 
Console.Write("input rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input colum: ");
        int colum = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colum];

Create2DArray(array);
Print2DArray(array);

void Create2DArray (int[,] arrayC)
{
Console.Write("input min ");
    int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max ");
    int max = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
             arrayC[i,j] = new Random().Next(min,max);
        }
    }
    
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumRows(int[,] array,int i)
{
    int arraySum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        arraySum += array[i,j];
    }
    return arraySum;
}

int minLine = 0;
int sumLine = SumRows(array,0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumRows(array,i);
    if(sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minLine = i;
    }
}

Console.WriteLine($"\n{minLine + 1} - string with min sum ({sumLine}) elements"); */

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив: */
void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] < 10)
        Console.Write($" 0{array[i,j]} ");
      else
        Console.Write($" {array[i,j]} ");

    }
    Console.WriteLine();
  }
}
int n = 4;
int[,] ArrayMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= ArrayMatrix.GetLength(0) * ArrayMatrix.GetLength(1))
{
  ArrayMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < ArrayMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= ArrayMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > ArrayMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(ArrayMatrix);



