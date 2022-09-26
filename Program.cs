// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* Console.Write("Введите кол-во строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, column];
GetArray(numbers);
Console.WriteLine();
Console.WriteLine("---> Задан двумерный массив: ");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); ++i)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; ++j)
    {
        for (int x = 0; x < numbers.GetLength(1) - 1; ++x)
        {
            if (numbers[i, x] < numbers[i, x + 1])
            {
                int temp = 0;
                temp = numbers[i, x];
                numbers[i, x] = numbers[i, x + 1];
                numbers[i, x + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("---> В итоге получается двумерный массив c упорядоченными значениями (по убыванию): ");
PrintArray(numbers);

void GetArray(int[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); ++i)
    {
        for (int j = 0; j < a1.GetLength(1); ++j)
        {
            a1[i, j] = new Random().Next(0, 10); // В примере положительные числа до 10
        }
    }
}

void PrintArray(int[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); ++i)
    {
        for (int j = 0; j < a1.GetLength(1); ++j)
        {
            Console.Write(a1[i, j] + "; ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
} */

//---------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

/* Console.Write("Введите кол-во строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] numbers = new int[rows, column];
GetArray(numbers);
PrintArray(numbers);
int min = Int32.MaxValue;
int result = 0;
Console.WriteLine();

for (int i = 0; i < numbers.GetLength(0); ++i)
{
    int b1 = 0;
    for (int j = 0; j < numbers.GetLength(1); ++j)
    {
        b1 = b1 + numbers[i, j];        
    }
    if (b1 < min)
    {
        min = b1;
        result++;
    }
}

Console.WriteLine("---> Номер строки с наименьшей суммой элементов: " + (result) + " = " + (min));

void GetArray(int[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); ++i)
    {
        for (int j = 0; j < a1.GetLength(1); ++j)
        {
            a1[i, j] = new Random().Next(0, 10); // В примере положительные числа до 10
        }
    }
}

void PrintArray(int[,] a1)
{
    for (int i = 0; i < a1.GetLength(0); ++i)
    {
        for (int j = 0; j < a1.GetLength(1); ++j)
        {
            Console.Write(a1[i, j] + "; ");
        }
        Console.WriteLine("");
    }
} */

//---------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Задача была решена с подсказками из интернета

/* Console.Write("Введите кол-во строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, column];
int[,] secondArray = new int[rows, column];
int[,] result = new int[rows, column];

GetArray(numbers);
PrintArray(numbers);

Console.WriteLine();

GetArray(secondArray);
PrintArray(secondArray);

Console.WriteLine();

if (numbers.GetLength(0) != secondArray.GetLength(1)) {
    Console.WriteLine("---> Число столбцов матрицы 1 должно равняется числу строк матрицы 2 ");
    return;
}
for (int i = 0; i < numbers.GetLength(0); ++i) {
    for (int j = 0; j < secondArray.GetLength(1); ++j) {
        result[i, j] = 0;
        for (int x = 0; x < numbers.GetLength(1); ++x) {
            result[i, j] += numbers[i, x] * secondArray[x, j];
        }
    }
}
Console.WriteLine("---> Произведение двух матриц: ");
PrintArray(result);
int ReadInt(string message) {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int[,] a1) {
    for (int i = 0; i < a1.GetLength(0); ++i) {
        for (int j = 0; j < a1.GetLength(1); ++j) {
           a1[i, j] = new Random().Next(1, 10); // В примере положительные числа до 10
        }
    }
}

void PrintArray(int[,] a1) {
    for (int i = 0; i < a1.GetLength(0); ++i) {
        for (int j = 0; j < a1.GetLength(1); ++j) {
            Console.Write($"{a1[i, j]} ");
        }
        Console.WriteLine();
    }
} */


//---------------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Задача была решена с подсказками из интернета

/* int rows, column, layers;
rows = column = layers = int.MaxValue; 
Random rnd = new Random();

while (rows * column * layers > 99) {
rows = rnd.Next(2, 9);                      
column = rnd.Next(2, 9);
layers = rnd.Next(2, 9);
}

Console.WriteLine();
Console.WriteLine($"Массив размером {layers} х {rows} х {column}\n");
int[] elements = new int[90];
int[,,] array = new int[layers, rows, column];
GetArray1(elements);
GetArray2(array, elements);
PrintArray(array);

void GetArray1(int[] a1) {
    for (int i = 0; i < a1.GetLength(0); ++i)
        a1[i] = 10 + i;
}

void GetArray2(int[,,] a1, int[] b1) {
    int count = 0; 
    int number;
    for (int x = 0; x < a1.GetLength(0); ++x)
        for (int i = 0; i < a1.GetLength(1); ++i)
            for (int j = 0; j < a1.GetLength(2); ++j) {
                number = rnd.Next(0, 90);
                while (b1[number] == 0) {
                    number = count;
                    count++;
                }
                a1[x, i, j] = b1[number];
                b1[number] = 0;
                count = 0;
            }
    
}

void PrintArray(int[,,] a1) {
    Console.Write("");
    for (int x = 0; x < a1.GetLength(0); ++x) {
        for (int i = 0; i < a1.GetLength(1); ++i) {
            for (int j = 0; j < a1.GetLength(2); ++j) {
                Console.Write($"{a1[x, i, j]}"); 
                Console.Write($" ({x}, {i}, {j})");
                if (x == a1.GetLength(0) -1 && i == a1.GetLength(1) - 1 && j == a1.GetLength(2) - 1) 
                Console.Write("");
                else 
                Console.Write("; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
} */


//---------------------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Задача была решена с подсказками из интернета

/* static int[,] GetArray(int n, int b) {
    int[,] array = new int[n, n];
    int count = 0;
    int i; 
    int j;
    while (b < n * n + 1) {
        for (j = count; j < n - count; j++) array[count, j] = b++;
        for (i = count + 1; i < n - count; i++) array[i, n - count - 1] = b++;
        for (j = n - count - 2; j > count; j--) array[n - count - 1, j] = b++;
        for (i = n - count - 1; i > count; i--) array[i, count] = b++;
        count++;
    }
    return array;
}

static void PrintArray(int[,] a1) {
    for (int i = 0; i < a1.GetLength(0); i++) {
        for (int j = 0; j < a1.GetLength(1); j++) {
            Console.Write(a1[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Random rnd = new Random();
int n = rnd.Next(4, 4); // Случайное значения массива n x n. В задаче указан массив 4 х 4
int b = 1;
PrintArray(GetArray(n, b));
Console.WriteLine(""); */