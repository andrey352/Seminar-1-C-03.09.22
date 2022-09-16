// Задача 25: Напишите цикл,к-й принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Решить задачу с использованием методов.   3, 5 -> 243 (3⁵), 2, 4 -> 16

// int getPower(int a, int b)
// {
//     int Power = Convert.ToInt32(Math.Pow(a, b));

//     return Power;
// }

// Console.Write("Input first number: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second number: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// int res = getPower(x1, x2);
// Console.WriteLine(res);

//----------------------------------------------------------------------------------------------

//Задача 27: Напишите программу, к-я принимает на вход число и выдаёт сумму цифр в числе.   452 -> 11, 82 -> 10

// int getSum(int a)
// {
//     int tmp = a;
//     int sum = 0;

//     while (tmp >= 1)
//     {
//     int cutNum = tmp % 10;
//     sum = sum + cutNum; 
//     tmp = tmp / 10;
//     }
// return sum;
// }

// Console.Write("Input a numbet: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int res = getSum(N);
// Console.WriteLine(res);

//---------------------------------------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива
// вводятся пользователем.     1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19],   6, 1, 33 -> [6, 1, 33]

// int[] getArray()
//     {
//         int[] myArray = new int[8];
//         for (int i = 0; i < myArray.Length; i++)
//         {
//             Console.Write($"Введите значение массива с индексом {i}\t");
//             myArray[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         return myArray;
//     }

// void PrintToConsole(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// int[] array = getArray();
// PrintToConsole(array);