// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool poli (int num)
// {  
// int onum = num /10000;
// int ptnum = num /1000;
// int tnum = ptnum % 10;
// int pfnum = num % 100;
// int fnum = pfnum /10;
// int finum = num % 10;
// {
// if (onum == finum && tnum == fnum)
//     return true;
//     else return false;
//     }
// }
// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool ispoli = poli(num);
// Console.WriteLine($"{num}->{ispoli}");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Не понимаю где ошибка разные варианты пробовала ничего не изменяется
// double dist (double x1, double y1, double d1, double x2, double y2, double d2, double dis)
// { 
//     double A = x2 - x1;
//     double B = y2 - y1;
//     double C = d1 - d2;
//     double dis = Math.Sqrt(A * A + B * B + C * C);
//        }
// Console.WriteLine("Введите координату X первой точки: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки: ");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z первой точки: ");
// double d1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X второй точки: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки: ");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z второй точки: ");
// double d2 = Convert.ToInt32(Console.ReadLine());
// dist(dis);

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void cub (int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.WriteLine($"{count} -> {Math.Pow(count, 3)}");
//         count++;
//     }
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// cub(num);
