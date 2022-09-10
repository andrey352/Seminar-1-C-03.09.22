// Задача 19. прогр к-я принимает пятизначное число и проверяет, является ли оно палиндромом. (14212->нет,12821-> да)

// Console.Write("Input a 5 digit number: ");
// string num = Console.ReadLine();

// if ((Convert.ToInt32(num)) > 9999 && (Convert.ToInt32(num)) < 100000) 
// {
//     if(Convert.ToInt32(num[0]) == Convert.ToInt32(num[4]) && Convert.ToInt32(num[1]) == Convert.ToInt32(num[3]))
//     {
//     Console.WriteLine("yes");
//     }

//     else Console.WriteLine("no");
// }
// else Console.WriteLine("it's not a 5 digit number");

//---------------------------------------------------------------------------------------------------------------

// Задача 21. прогр, к-я принимаеt координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84

// double getDistanse (int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

// return dist;
// }

// Console.Write("input coordinate x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("input coordinate y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("input coordinate z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("input coordinate x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("input coordinate y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("input coordinate z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double res = getDistanse(x1, y1, z1, x2, y2, z2);
// Console.WriteLine(Math.Round(res, 2));

//-------------------------------------------------------------------------------------------------------

// Задача 23. Прогр, к-я принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. (3 -> 1, 8, 27)

// int[] getCube (int n)
// {
//     int[] tableCubes = new int[n];
//     for (int i = 1; i <= n; i++)
//     {
//         tableCubes[i - 1] = i * i * i;
//     }
// return tableCubes;
// }

// Console.Write("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] res = getCube(n);
// for (int i = 0; i <= n; i++) {
//     Console.WriteLine(res[i]);
// }
