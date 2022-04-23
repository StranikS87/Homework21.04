// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Ввведите пятизначное числоЖ: ");
int num = int.Parse(Console.ReadLine());

if(num > 0 & num <= 99999 )
{
   int x1 = num / 10000 % 10;
   int x2 = num % 10;
   
   int y1 = num / 1000 % 10;
   int y2 = num / 10 % 10;
  
   if (x1 == x2 & y1 == y2)
   {
       Console.WriteLine($"Число {num} является палиндромом");
   } else
       Console.WriteLine($"Число {num} НЕ является палиндромом");
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты трех чисел: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
int length = (int) Math.Pow(x2 - x1, 2) + (int) Math.Pow (y2 - y1, 2) + (int) Math.Pow (z2 - z1, 2);
double result = Math.Round(Math.Sqrt(length), 2);
Console.WriteLine($"Расстояние между двумя точками равно {result}");


// Задача 23. Напишите программу, которая принимает на вход число N и выдаёт тааблицу кубов чисел от 1 до N

Console.WriteLine("Введите чило N");
int N = int.Parse(Console.ReadLine());
int index = 1;
while (index <= N)
{
    Console.WriteLine(Math.Pow(index, 3));
    index++;
}