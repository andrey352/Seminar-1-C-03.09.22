// Задача 10: Напишите прог-у, к-я принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5

// Console.Write("Enter a three digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string stringNum = Convert.ToString(num);
// Console.WriteLine("Second digit of number: - "+stringNum[1]);

// вариант решения №2

// void secondDigit (int num)
// {
//     int x1 = num / 10;
//     int x2 = x1 % 10;
//     Console.WriteLine($"Вторая цифра числа {num} - {x2}");
// }

// Console.Write("Enter a three digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// secondDigit (num);

//----------------------------------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string stringNum = Convert.ToString(num);
// if (stringNum.Length > 2) {
//     Console.WriteLine("Third digit of number - " + stringNum[2]);
// }
// else {
//     Console.WriteLine("no third digit");
// }

// вариант №2

// void thirdNum (int num)
// {
//     if(num > 99)
//     {
//         while(num > 999)
//         {
//             num = num / 10;
//         }
//         int x = num % 10;
//         Console.WriteLine(x);
//     }
//     else Console.WriteLine("no third digit");
// }

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// thirdNum (num);

//--------------------------------------------------------------------------------------------------------------------------

// № 15: Напишите прог-у,к-я принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 7- да

// void vacation (int day)
// {
// if (day >= 5) {
//     Console.WriteLine("Yes");
// }
// else Console.WriteLine("No");
// }

// Console.Write("Enter a day of week (1-7): ");
// int day = Convert.ToInt32(Console.ReadLine());

// vacation (day);
