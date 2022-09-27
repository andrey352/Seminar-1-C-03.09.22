
// 1.  прог к-я выводит случ двухзнач число и показывает какая цифра больше

// void compareDigits()
//     {
//     int x = new Random().Next(10,100);
//     Console.WriteLine($"Сгенерировали случайное число: {x}");
//     int x1 = x / 10;
//     int x2 = x % 10;
//     if (x1>x2) Console.WriteLine("the first digit is greater than the second");
//     else if (x1<x2) Console.WriteLine("the second digit is greater than the first");
//     else Console.WriteLine("This is a pollindrome");
//     }

// compareDigits();

//-----------------------------------------------------------------------------------------

// 2.  Прогр к-я выводит случ 3х значное число и удаляет вторую цифру из него

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int x1 = num/100;
// int x2 = num%10;
// Console.Write($"{x1}{x2}");

//--------------------------------------------------------------------------------------------------------

// 3.  Прогр к-я будет принимать два числа и выводить, является ли второе число кратным первому
// Если число 2 не кратно 1, то выводится остаток от деления

// Console.Write("Enter a number 1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number 2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int res = x1 % x2;
// if (res == 0) {
//     Console.WriteLine("Кратно"); }
// else {
//     Console.WriteLine("Не кратно, остаток от деления - "+res); }

// 2nd version:
// void numbers(int x1, int x2) 
// {
//     if(x1 % x2 == 0) Console.WriteLine("Кратно");
//     else Console.WriteLine("Не кратно, остаток от деления - {x1 % x2}");
// }

// Console.Write("Enter a number 1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Enter a number 2: ");
// int x2 = int.Parse(Console.ReadLine());

// numbers(x1, x2);
// Console.WriteLine();

//-----------------------------------------------------------------------------------------

// 4.  Прогр, к-я принимает число и проверяет, крато ли оно одновременно 7 и 23

// void numbers(int x)
// {
//     if(x % 7 + x % 23 == 0) Console.WriteLine("Кратно");
//     else Console.WriteLine("Не кратно");
// }

// Console.Write("Enter a number: ");
// int x = Convert.ToInt32(Console.ReadLine());

// numbers(x);
// Console.WriteLine();

// ---------------------------------------------------------------------------------------------------

// 5.  Прогр к-я принимает два числа и выводит, явл-ся ли первое число квадратом второго(5-25-да)

// void square (int num1, int num2)
// {
//     if(num2 * num2 == num1) Console.WriteLine("the first number is the square of the second number");
//     else Console.WriteLine("It is not");
// }

// Console.Write("Enter a number 1: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Enter a number 2: ");
// int num2 = int.Parse(Console.ReadLine());

// square (num1, num2);
// Console.WriteLine();

// =============================================================================================================

//   Seminar 3. 

// Обзор массива и цикла "for"

// int[] nums = new int[10] {10, 45, 23, 45, 65, 23, 43, 56, 23, 23};
// int max = nums[0];
// for (int i = 0; i < nums.Length; i++)    //int i = 0; i++ - счетчик
// {
//     if (nums[i] > max)
//     {
//         max = nums[i];
//     }
// }
// Console.WriteLine(max);

//-----------------------------------------------------------------------------------------------------------

// Задача 17. Прогр, к-я приимает координаты точки (X и Y), причем Х не равно 0 и У не равно 0, и выдает номер
// четверти плоскости, в которой находится эта точка

// определение четверти точки
// int GetPointArea(int x, int y)
// {
//     if (x > 0 && y > 0) {
//         return 1;
//     }

//     if (x < 0 && y > 0) {
//         return 2;
//     }

//     if (x < 0 && y < 0) {
//         return 3;
//     }

//     if (x > 0 && y < 0) {
//         return 4;
//     }
//     return 0;
// }

// Console.Write("Enput X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enput y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int areaNum = GetPointArea(x, y);
// Console.WriteLine($"Area = {areaNum}");

//------------------------------------------------------------------------------------------------------------

// Зад 21. Прогр, к-я принимает координаты двух точек и нах-т расстояние между ними в 2D пространстве

// double GetDistanse (int x1, int y1, int x2, int y2) 
// {
//     double distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

//     return distanse;
// }


// Console.Write("Input x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double result = GetDistanse (x1, y1, x2, y2);
// Console.WriteLine($"Расстояние равно: {Math.Round(result, 2)}");

//-------------------------------------------------------------------------------------------------

// Прогр к-я принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

// int[] getSquaresNumer(int numer)
// {
//     int[] squaresNumers = new int[numer];

//     //Заполнение массива результата
//         for (int i = 1; i <= numer; i++) {
//         squaresNumers [i - 1] = i * i;
//     }   
//     return squaresNumers;     
// }

// Console.Write("Input name: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] result = getSquaresNumer(num);
// for (int i = 0; i < result.Length; i++) {
// Console.WriteLine(result[i]);
// }

//========================================================================================================


// Семинар №4

// Задача. Прогр, принимает число А и выдает сумму чисел от 1 до А

// int GetSum(int number)
// {
//     int sum = 0;
//     if (number > 0)
//     {
//         for (int i = 1; i <= number; i++)
//         {
//             sum = sum + i;
//         }
//     }
//     if (number < 0)
//         {
//             for (int i = 1; i >= number; i--)
//             {
//                 sum = sum + i;
//             }
//         }
//     return sum;
// }

// try
// {
    // Console.Write("input A: ");
    // int a = int.Parse(Console.ReadLine());

//     int sum = GetSum(a);
//     Console.WriteLine(sum);
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Incorrect data entered");
// }

//------------------------------------------------------------------------------------------

// Задача 24. Принимает число и выдает кол-во цифр в числе (456 -> 3)

// int getDigit(int number)
// {
//     int countDigit = 0;                 // кол-во цифр в числе
//     int tempNum = Math.Abs(number);     // временная переменная для хран входного значения
//     while (tempNum != 0)
//     {
//         tempNum = tempNum / 10;
//         countDigit++;
//     }
//     return countDigit;
// }


// Console.Write("input number: ");
// int a = int.Parse(Console.ReadLine());

// int countDigit = getDigit (a);
// Console.WriteLine(countDigit);

//----------------------------------------------------------------------------------------------

// Задача 28. Принимает число N и выдает произведение чисел от 1 до N (4 -> 24)

// int getNum(int n)
// {
//     int mult = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         mult = mult * i;
//     }
//     return mult;
// }

// Console.Write("input N: ");
// int n = int.Parse(Console.ReadLine());

// int res = getNum(n);
// Console.WriteLine(res);

//----------------------------------------------------------------------------------------------

//  Задача. Выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

// int [] getArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// void PrintArrayToConsole(int[] array)
// {
//     for(int i = 0; i <= array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// int[] array = getArray();
// PrintArrayToConsole(array);

//--------------------------------------------------------------------------------------

// Задача с ютубканала SimpleCode - ЗАПОЛНИТЬ МАССИВ С КЛАВИАТУРЫ | ВВОД МАССИВА С КОНСОЛИ C# | СИ ШАРП УРОКИ | ДОМАШНИЕ ЗАДАНИЯ # 6


// Console.Write("Введите кол-во элементов массива:\t");
// int elementsCount = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[elementsCount];

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите элемент массива с индексом {i}: \t");
//     myArray[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Вывод массива");

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.WriteLine(myArray[i]);
// }

//=========================================================================================

// 14.09.22 Семинар №5 

// задача №31. Задайте массив из 12 эл-тов, заполненный случайными числами, из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных эл-тов.

// int[] getArray(int size, int startValue, int endValue)
// {
//     var array = new int[size];                   // тоже что и int[] array = new int[]
//     var random = new Random();                   // Random random
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(startValue, endValue + 1);
//     }
//     return array;
// } 

// int getPosiNum(int[] array)
// {
//     var sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// int getSumNegativNumbers(int[] array)
// {
//     var sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }

// var array = getArray(12, -9, 9);
// var sumPositive = getPosiNum(array);
// var sumNegative = getSumNegativNumbers(array);

// Console.WriteLine($"Сумма положительных - {sumPositive}\n" + $"Сумма отрицательных - {sumNegative}");

//-----------------------------------------------------------------------------------------------

// Задача 32. Напишите прог-му замена элементов массива: положтительнве элемены замените на отрицательные и наоборот
// [-4, -8, 2] -> [4, 8, -2]


// int[] getRevers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * -1;
//     }
//     return array;
// }

// var array = new int[4] {1, 2, -3, -4};

// var resArray = getRevers(array);
// for(int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }

//---------------------------------------------------------------------------------------------

// Зад. 33. Задайте массив. Напишите прогр, к-я определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7 , 19, 345] -> нет

// bool getSolution(int[] array, int num)
// {
//     bool result = false;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num)
//         {
//             result = true;
//             break;                               // break обязателен, т к без него выдаст неверный результат
//         }                                        // кроме если искомое число - последнее в массиве
//         else result = false;
//     }
//     return result;
// }


// try
// {
// int[] myArray = {6, 7 , 19, 345};
// Console.Write("Input a number: ");
// var num = Convert.ToInt32(Console.ReadLine());

// var resArray = getSolution(myArray, num);
// Console.WriteLine(resArray);
// }

// catch 
// {
//     Console.WriteLine("incorrect data entered");
// }

//----------------------------------------------------------------------------------------------
// не решена - ошибки в коде

// Зад 35. Задайте одномерный массив из 123 чисел. Найти кол-во элементов массива, зн-я к-х лежат в отрезке[10,99]
// Пример для массива из 5 эл-в: [5, 18, 123, 6, 2] -> 1

// var array = new int[123];
// var random = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(-1000, 1000);
// }


// int getCount (int[] array)
// {
//     int num = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 $$ array[i] <= 99)
//         {
//             num = num + 1;
//             Console.WriteLine(array[i]);
//         }
//     }
//     return num;
// }


// int res = getCount(array);
// Console.WriteLine(res);

//------------------------------------------------------------------------------------------------

// Зад 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21

// int[] GetPairMult(int[] array)
// {
//     int size = 0;
//     int[] result = null;

//     if (array.Length % 2 == 0)
//     {
//         size = array.Length / 2;
//         result = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             result[i] = array[i] * array[array.Length - i - 1];
//         }
//     }
//     else
//     {
//         size = array.Length / 2 + 1;
//         result = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             if (i == (size - 1))
//             {
//                 result[i] = array[i];
//             }
//             else
//             {
//                 result[i] = array[i] * array[array.Length - i - 1];
//             }
//         }
//     }
//     return result;
// }

// int[] array = new int[] {1,4,6,3,7};
// int[] result = GetPairMult(array);

// ==============================================================================================

// 16.09.22 Семинар №6 Продолжение решения задач с одномерными массивами

// Задача 39. Напишите прогр, к-я перевернет одномерный массив. [1 2 3 4 5] -> [5 4 3 2 1]

// int[] getReversArray (int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = array[array.Length - 1 - i];
//     }
//     return result;
// }

// int[] array = {1,2,3,4,5};
// int[] result = getReversArray(array);

// for(int i = 0; i < array.Length; i++)
// {
//         Console.WriteLine(result[i]);
// }
// Console.WriteLine("");

// 2й вариант решения без использования дополн массива (минус в том что исходный массив изменится)

// int[] getReversArray (int[] array)
// {
//     int tempStorage = array[0];
//     for(int i = 0; i < array.Length /2; i++)
//     {
//         tempStorage = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = tempStorage;
//     }
//     return array;
// }

// int[] array = {1,2,3,4,5};
// int[] result = getReversArray(array);

// for(int i = 0; i < array.Length; i++)
// {
//         Console.WriteLine(result[i]);
// }
// Console.WriteLine("");

//-------------------------------------------------------------------------------------

// Зад 40. прогр, к-я принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треуг: каждая сторона треуг меньше суммы двух других сторон

// bool treangle(int a, int b, int c)
// {
//     if(a + b > c && a + c > b && b + c > a) return true;

//     else return false;
// }


// Console.WriteLine("Input a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input c");
// int c = Convert.ToInt32(Console.ReadLine());

// bool res = treangle(a, b, c);
// Console.WriteLine(res);

//-----------------------------------------------------------------------------------------

// Зад 42. Прогр, к-я преобразует десятичное число в двоичное. 45 -> 101101
//  27 13  6  3  1    делим на два и записываем снизу остаток от деления
//   1  1  0  1  1    читаем справа налево

// string reversString(string s)
// {
//     char[] arr = s.ToCharArray();
//     Array.Reverse(arr);
//     return new string(arr);
// }

// string getToInt2 (int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = result + (num % 2).ToString();   // метод перевода р-та в строку
//         num = num / 2;
//     }
//     result = reversString(result);
//     return result;
// }

// Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = getToInt2(num);
// Console.WriteLine(result);

//-----------------------------------------------------------------------------------------

// Зад. 44 Не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа Фибоначи: 0 и 1.
// Если N = 7 -> 0 1 1 2 3 5 8  

// int [] getFibo(int n)
// {
//     int[] arr = new int[n];
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i < n; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     return arr;
// }

// Console.WriteLine("Input n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");

// int[] res = getFibo(n);
// Console.WriteLine("Вывод чисел фибо: ");
// for(int i = 0; i < res.Length; i++)
// {
//     Console.WriteLine(res[i]);
// }

//=============================================================================================

// Семинар №7. Двухмерные массивы.
//Зад 46. Задайте двухмерный массив размером m*n, заполненный случайными целыми числами.
// m = 3, n = 4. 1 4 8 9 / 5 -2 33  -2 / 77 3 8 1

// размерность массива:
// int n = 0;
// int m = 0;
// Console.Write("Введите кол=во строк (N): ");
// bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
// if (!parseNIsOk)                                           // если не получилось спарсить
// {
//     Console.WriteLine("Введено значение неверного формата");
//     return;
// }
// else
// {
//     n = numberN;
// }

// Console.Write("Введите кол=во столбцов (M): ");
// bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
// if (!parseMIsOk)
// {
//     Console.WriteLine("Введено значение неверного формата");
//     return;
// }
// else
// {
//     m = numberM;
// }

// int[,] array = new int[n, m];

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         Console.Write(array[i, j]);
//     }
//     Console.WriteLine();
// }

// Console.ReadKey();

//--------------------------------------------------------------------------------------

// Зад. 48. Задайте двухмерный массив размером m*n, каждый элемент в массиве находится по формуле: A = m + n,
// Выведите полученный результат на экран. m = 3, n = 4 -> 0123/1234/2345

// int[,] GetArray(int n, int m) 
// {
//     int[,] array = new int[n, m];

//     for(int i = 0; i < n; i++)
//     {
//         for(int j = 0; j < m; j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
      
//     return array;
// }

// int n = 0;
// int m = 0;
// Console.Write("Введите число строк N: ");
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

// int[,] resArray = GetArray(n, m);

// for(int i = 0; i < n; i++)
// {
//     for(int j = 0; j < m; j++)
//     {
//         Console.Write(resArray[i, j] + " ");
//     }
//     Console.WriteLine();
// }

//====================================================================================================

// Семинар 8. Двухмерные массивы, продолжение.

// Зад 53. Задайте двухмерный массив. Напишите прогр, к-я поменяет местами первую и последнюю строку массива

// int[,] mass = new int[3, 3] {{1,2,3}, {4,5,6}, {7,8,9}};

// for(int i = 0; i < mass.GetLength(0); i++)
// {
//     for(int j = 0; j < mass.GetLength(1); j++)
//     {
//         int tmp = mass[i, j];
//         mass[i, j] = mass[mass.GetLength(1) - 1, j];
//         mass[mass.GetLength(1) - 1, j] = tmp;
//     }
//     break;
// }

// for(int i = 0; i < mass.GetLength(0); i++)
// {
//     for(int j = 0; j < mass.GetLength(1); j++)
//     {
//         Console.Write(mass[i, j]);
//     }
//     Console.WriteLine();
// }

//----------------------------------------------------------------------------------------------------

// Зад 55. Задайте двухмерный массив. Напишите прогр, к-я заменяет строки на столбцы. В случае если это невозможно, выводим собщ

// int[,] mass = new int[3, 3] {{1,2,3}, {4,5,6}, {7,8,9}};

// int[,] newMass = new int[3, 3];
// for(int i = 0; i < newMass.GetLength(0); i++)
// {
//     for(int j = 0; j < newMass.GetLength(1); j++)
//     {
//         newMass[i, j] = mass[j, i];
//     }
// }

// for(int i = 0; i < newMass.GetLength(0); i++)
// {
//     for(int j = 0; j < newMass.GetLength(1); j++)
//     {
//         Console.Write(newMass[i, j] + " ");
//     }
//     Console.WriteLine();
// }

//----------------------------------------------------------------------------------------------

// Зад 57. Составить частотный словарь эл-тов двухмерного массива. Частотный словарь содержит информацию
// о том, сколько раз встечается эл-т входных данных.

// int[,] mass = new int[3, 3] {{1,2,3}, {4,5,6}, {7,8,8}};

// int max = mass[0, 0];
// int min = mass[0, 0];


// for(int i = 0; i < mass.GetLength(0); i++)
// {
//     for(int j = 0; j < mass.GetLength(1); j++)
//     {
//         if(mass[i, j] > max) max = mass[i, j];
//     }
// }
// Console.WriteLine(max);


// for(int i = 0; i < mass.GetLength(0); i++)
// {
//     for(int j = 0; j < mass.GetLength(1); j++)
//     {
//         if(mass[i, j] < min) min = mass[i, j];
//     }
// }
// Console.WriteLine(min);


// int[] myArray = new int[max - min + 1];

// for(int a = 0; a < (max-min+1); a++)
// {
//     for(int i = 0; i < mass.GetLength(0); i++)
//     {
//         for(int j = 0; j < mass.GetLength(1); j++)
//         {
//             if(mass[i, j] == (a + min)) myArray[a] = myArray[a] + 1; 
//         }
//     }
// }

// for(int i = 0; i < (max-min+1); i++)
// {
//     if(myArray[i] != 0)
//     {
//         Console.WriteLine($"Элемент {i+min} встречается {myArray[i]} раз");
//     }
// }


