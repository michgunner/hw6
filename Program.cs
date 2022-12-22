//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void EnterNumber(int size)
{
   int count = 0;
   int number; 
   for (int i=1; i<=size; i++)
   {
      Console.Write($"Please, enter number: ");
      number = Convert.ToInt32(Console.ReadLine());
      if(number>0) count++;
   }
   Console.WriteLine("Count of numbers more than 0 are - " + count);
}

Console.Write($"Please, enter how much numbers you want to enter: ");
int count = Convert.ToInt32(Console.ReadLine());
EnterNumber(count); 



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(int k1, int k2, int b1, int b2)
{
   if(k1==k2)
      Console.WriteLine("Dot's dont have intersection point");
   else
   {
      double x = (b2-b1)/(k1-k2);
      double y = k1*x + b1;
      Console.WriteLine($"Point of intersection: x({x}), y({y})");
   }
}

Console.Write($"Please, enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Please, enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Please, enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Please, enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(k1, k2, b1, b2);