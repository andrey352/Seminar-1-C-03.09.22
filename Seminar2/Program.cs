
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

















