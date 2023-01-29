// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа : ");

int X, Y;

X = Convert.ToInt32(Console.ReadLine());

Y = Convert.ToInt32(Console.ReadLine());

if (X > Y)
{
    Console.WriteLine("{0} наибольшее число", X);
}
else
{
    Console.WriteLine("{0} наибольшее число ", Y);
}



