
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






