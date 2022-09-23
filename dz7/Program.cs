// Зад 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] GetArray(int n, int m) 
// {
//     double[,] array = new double[n, m];

//     for(int i = 0; i < n; i++)
//     {
//         for(int j = 0; j < m; j++)
//         {
//             array[i, j] = new Random().NextDouble() * 100;
//         }
//     }
      
//     return array;
// }

// int n = 0;
// int m = 0;
// Console.Write("Введите число строк (N): ");
// bool intParseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
// if (!intParseNIsOk)
// {
//     Console.WriteLine(" введено некорректное значение");
//     return;
// }
// else
// {
//     n = numberN;
// }

// Console.Write("Введите число столбцов (M): ");
// bool intParseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
// if (!intParseNIsOk)
// {
//     Console.WriteLine(" введено некорректное значение");
//     return;
// }
// else
// {
//     m = numberM;
// }

// double[,] resArray = GetArray(n, m);

// for(int i = 0; i < n; i++)
// {
//     for(int j = 0; j < m; j++)
//     {
//         Console.Write(resArray[i, j] + " ");
//     }
//     Console.WriteLine();
// }

//----------------------------------------------------------------------------------------------

// Зад 50. Напишите прогр, к-я на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// int n = 3;
// int m = 4;
// int[,] MyArray = new int[n, m];

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         MyArray[i, j] = new Random().Next(1, 10);
//     }
// }

// for(int i = 0; i < n; i++)
// {
//     for(int j = 0; j < m; j++)
//         {
//             Console.Write(MyArray[i, j] + " ");
//         }
//     Console.WriteLine();
    
// }

// Console.Write($"Введите значение строки: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Введите значение столбца: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > n || b > m)
// {
//     Console.WriteLine("Такого числа нет");
// }
// else
// {
//     int c = MyArray[a, b];
//     Console.WriteLine(c);
// }

//--------------------------------------------------------------------------------------

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] mass = new int[3, 3] {{1,2,3}, {5,6,7}, {9,10,11}};

// for (int i = 0; i < 3; i++)
// {
//     int average = 0;
//     for (int j = 0; j < 3; j++)
//     {
//         average = average + mass[j, i];
//     }
//     Console.WriteLine($"Cреднее арифметическое элементов столбца {i} = {(float)average/3}");
// }















