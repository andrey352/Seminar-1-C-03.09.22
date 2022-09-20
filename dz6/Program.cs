// Зад 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 3


// Console.Write("Введите числа через пробел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Кол-во чисел больше нуля: {count}");

//----------------------------------------------------------------------------------------------------------

// Зад 43: Прогр, к-я найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// int[] getPoint (int k1, int b1, int k2, int b2)
// {
//     var resArray = new int[2];
//     resArray[0] = (b2-b1)/(k1-k2);
//     resArray[1] = (k1*(b2-b1))/((k1-k2)+b1);
//     return resArray;
// }

// Console.Write("Input k1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input b1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input k2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input b2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// var res = getPoint(b1, k1, b2, k2);
// Console.WriteLine(res);
// Console.WriteLine("Координаты точки пересечения x и y:");
// for (int i = 0; i < res.Length; i++)
// {
//     Console.WriteLine(res[i]);
// }








