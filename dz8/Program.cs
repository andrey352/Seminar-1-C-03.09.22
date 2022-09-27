// Зад 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива. Например, задан массив:
// 1 4 7 2   ->   7 4 2 1
// 5 9 2 3        9 5 3 2
// 8 4 2 4        8 4 4 2

// int[,] mass = new int[3, 4] {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

// for(int i = 0; i < mass.GetLength(0); i++)
// {
//     for(int j = 0; j < mass.GetLength(1); j++)
//     {
//         for(int k = 0; k < mass.GetLength(1) - 1; k++)
//         {
//             if(mass[i, k] < mass[i, k+1])
//             {
//                 int tmp = mass[i, k];
//                 mass[i, k] = mass[i, k+1];
//                 mass[i, k+1] = tmp;
//             }
//         }
//     }
// }

// for(int i = 0; i < mass.GetLength(0); i++)
// {
//     for(int j = 0; j < mass.GetLength(1); j++)
//     {
//         Console.Write(mass[i, j] + " ");
//     }
//     Console.WriteLine();
// }

//------------------------------------------------------------------------------------------------

// Зад 56: Задайте прямоугольный двумерный массив. Напишите прогр, к-я будет находить строку с наименьшей
//  суммой элементов.

// int[,] mass = {{1,2,3}, {4,5,6}, {7,8,9}};

// int sum = int.MaxValue;
// int index = 0;

// for (int i = 0; i < 3; i++)
// {
//     int temp = 0;
//     for (int j = 0; j < 3; j++)
//     {
//         temp += mass[i, j];
//     }
//     if(temp < sum)
//     {
//         sum = temp;
//         index = i;
//     }
// }

// Console.WriteLine("Строка: "+index+", сумма: "+sum);

// for (int i = 0; i < 3; i++)
// {
//     Console.Write(mass[index, i]+" ");
// }       

//--------------------------------------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4    ->    18 20
// 3 2 | 3 3          15 18

// int[,] mass1 = {{2,4}, {3,2}};
// int[,] mass2 = {{3,4}, {3,3}};
// int[,] resMass = new int[mass1.GetLength(0), mass1.GetLength(1)];

// for (int i = 0; i < resMass.GetLength(0); i++)
// {
//     for (int j = 0; j < resMass.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < resMass.GetLength(0); k++)
//         {
//             sum += mass1[i,k] * mass2[k,j];
//         }
//         resMass[i,j] = sum;
//     }
// }

// for (int i = 0; i < resMass.GetLength(0); i++)
// {
//     for (int j = 0; j < resMass.GetLength(1); j++)
//     {
//         Console.Write(resMass[i,j] + " ");
//     }
//     Console.WriteLine();
// }

//---------------------------------------------------------------------------------------------

//Зад 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите прогр, к-я будет построчно 
//выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3d = new int[3,3,3];

// for (int i = 0; i < array3d.GetLength(0); i++)
// {
//     for (int j = 0; j < array3d.GetLength(1); j++)
//     {
//         for (int z = 0; z < array3d.GetLength(2); z++)
//         {
//             array3d[i,j,z] = new Random().Next(10,99);
//         }
//     }
// }

// for (int i = 0; i < array3d.GetLength(0); i++)
// {
//     for (int j = 0; j < array3d.GetLength(1); j++)
//     {
//         for (int z = 0; z < array3d.GetLength(2); z++)
//         {
//             Console.WriteLine($"{array3d[i,j,z] + ' '} {i},{j},{z}");
//         }
//         Console.WriteLine();
//     }
// }