// Зад 34: Задайте массив заполненный случ-ми положительными трёхзначными числами. Напишите программу, 
// которая покажет кол-во чётных чисел в массиве.    [345, 897, 568, 234] -> 2

// int[] myArray = new int[4];
// var random = new Random();
// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = random.Next(100, 999);
//     Console.WriteLine(myArray[i]);
// }

// int getQuant(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;

// }

// int res = getQuant(myArray);
// Console.WriteLine($"Количество четных чисел: {res}");

//-------------------------------------------------------------------------------------------

// Зад 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.    [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0

// int[] myArray = new int[4];
// var random = new Random();

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = random.Next(-99, 99);
//     Console.WriteLine(myArray[i]);
// }

// int getSum (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     if (i % 2 != 0)
//     {
//         sum = sum + array[i];
//     }
//     return sum;

// }

// int res = getSum(myArray);
// Console.WriteLine($"Сумма эл-тов с нечетными ндексами: {res}");

//---------------------------------------------------------------------------------------

// Зад 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов
// массива.   [3 7 22 2 78] -> 76

// double[] myArray = {2.5, 4.6, 34.3, 6.1, 13.2};

// double getMax (double[] array)
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }

// double getMin (double[] array)
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }

// double resMin = getMin(myArray);
// double resMax = getMax(myArray);
// Console.WriteLine($"Разница между макс {resMax} и мин {resMin} значениями: {resMax - resMin}");

//-------------------------------------------------------------------------------

// Зад 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21

// int[] firstArray = {1,2,3,4,5};

// void printToConsole(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// int[] getArray(int[] array)
// {    
//     if(array.Length % 2 == 0)
//     {
//         int[] newArray = new int[array.Length/2]; 
//         for (int i = 0; i < array.Length/2; i++)
//         {
//             newArray[i] = array[i] * array[(array.Length - 1) - i];
//         }
//         return newArray;
//     }
//     else
//     {
//         int[] newArray = new int[array.Length/2 + 1]; 
//         for (int i = 0; i < array.Length/2; i++)
//         {
//             newArray[i] = array[i] * array[(array.Length - 1) - i];
//             newArray[array.Length/2] = array[array.Length/2];
//         }
//         return newArray;
//     }
// }

// int[] resArray = getArray(firstArray);
// printToConsole(resArray);


