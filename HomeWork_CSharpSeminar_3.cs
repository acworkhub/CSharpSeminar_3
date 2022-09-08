// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// System.Console.WriteLine("Введите пятизначное число для проверки на полиндром");
// int n = Convert.ToInt32(Console.ReadLine());
// int tempresult1 = n/1000; 
// int tempresult2 = (n % 10)*10 + (n % 100)/10;

// if(n>=10000 & n<100000)

//     {
//         if (tempresult1 == tempresult2)
//         {
//             System.Console.WriteLine($"Число {n} является полиндромом.");
//         }

//         else
//         {

//             System.Console.WriteLine($"Число {n} не является полиндромом.");
//         }
//     }
//     else
//     {
        
//         System.Console.WriteLine("Число n должно быть целым числом в интервале от 1х10^5 до 1х10^6");

//     }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// System.Console.WriteLine("Введите координаты точки Х1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты точки Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты точки Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координаты точки Х2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты точки Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты точки Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());


// double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

// System.Console.WriteLine($"Растояние между двумя точками составляет {Math.Round (result, 2)}");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// System.Console.WriteLine("Введите число ограничения интервала N");
// int n = Convert.ToInt32(Console.ReadLine());


// int i = 1;
// double result  = 1;

//  System.Console.WriteLine($"Таблица чисел возведенных в степень ^3 в интервале 1 => {i}");
// while (i<=n)
// {
//     result = Math.Pow(i, 3);
//     System.Console.WriteLine($"{i}^3 => {result}");
//     i++;
// }
