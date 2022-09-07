// System.Console.WriteLine("Введите X");
// int x = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 & y > 0 )
// {
//     System.Console.WriteLine($"Точка с координатами ({x},{y}) пренадлежит первой координатной четверти.");
// }

//  else if (x < 0 & y < 0 )
// {
//     System.Console.WriteLine($"Точка с координатами ({x},{y}) пренадлежит второй координатной четверти.");
// }

//  else if (x < 0 & y > 0)
// {
//     System.Console.WriteLine($"Точка с координатами ({x},{y}) пренадлежит третьей координатной четверти.");
// }

//  else if (x > 0 & y < 0 )
// {
//     System.Console.WriteLine($"Точка с координатами ({x},{y}) пренадлежит четвертой координатной четверти.");
// }







// System.Console.WriteLine("Введите номер координатной четверти");
// int n  = Convert.ToInt32(Console.ReadLine());
// if ( n>=1 & n<=4)

//     {
//         if(n == 1)
//         {
//             System.Console.WriteLine($"Координатная четверть {n} Значения  0<X<N // 0<Y<N");
//         }
//        else if(n == 2)
//         {
//             System.Console.WriteLine($"Координатная четверть {n} Значения  -N<X<0 // 0<Y<N");
//     }
//         else if(n == 3)
//         {
//             System.Console.WriteLine($"Координатная четверть {n} Значения  -N<X<0 // -N<Y<0");
//         }
        
//         else if(n == 4)
//         {
//             System.Console.WriteLine($"Координатная четверть {n} Значения  0<X<N // -N<Y<0");
//         }   
//     }
//     else
//     {
//        System.Console.WriteLine("Введите корректный номер координатной четверти"); 
//     }

// switch (n)
// {
//     case 1:
//             System.Console.WriteLine($"Координатная четверть {n} Значения  0<X<N // 0<Y<N");
//     break;
//     case 2:
//             System.Console.WriteLine($"Координатная четверть {n} Значения  -N<X<0 // 0<Y<N");
//     break;

//     case 3:
//             System.Console.WriteLine($"Координатная четверть {n} Значения  0<X<N // -N<Y<0");
//     break;

//     case 4:
//             System.Console.WriteLine($"Координатная четверть {n} Значения  -N<X<0 // -N<Y<0") ;
//     break;
           
//     default:
//              System.Console.WriteLine("Введите корректный номер координатной четверти"); 
//     break;
// }


// System.Console.WriteLine("Введите точку X1");
// int X1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку Y1");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите точку X2");
// int X2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// int point1 = X2-X1;
// int point2 = Y2-Y1;

// double resalt = Math.Sqrt((point1*point1)+(point2*point2));

// System.Console.WriteLine(resalt);

// System.Console.WriteLine("Введите число  ограничения интервала N");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// double resault = 1;

// while (i <= n)
//     {
//         resault = Math.Pow(i,2);
//         System.Console.WriteLine(resault);
//         i++;
//   