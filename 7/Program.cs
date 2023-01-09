// Задача 47. Задайте двумерный массив размером M x N, заполненный случайными вещественными числами

Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m,n];
FillArrayRandomNumbers(array);

void FillArrayRandomNumbers (double[,] array) {


    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write(array [i,j] + "\t");
        }
    Console.WriteLine();
    }
}



// Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве и возвращает значение этого
// элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [10,10];

FillArrayRandomNumbers(array);

void FillArrayRandomNumbers (int[,] array) 
{


    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            array[i,j] = new Random().Next(1, 10);
            Console.Write(array [i,j] + " ");
        }
    Console.WriteLine();
    }
}

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {array[n-1,m-1]}");
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,]array = new int [m,n];

Console.WriteLine("Среднее арифметическое элементов каждого столбца: ");

FillArrayRandomNumbers (array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i,j]);
    }
    avarage = avarage / m;
    
    Console.Write (avarage + ", ");
}
Console.WriteLine();

Console.WriteLine();
PrintArray(array);

void FillArrayRandomNumbers (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next (0,10);
        }
        
    }
}


void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
