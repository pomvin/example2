// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа : ");

int X, Y, N;

X = Convert.ToInt32(Console.ReadLine());

Y = Convert.ToInt32(Console.ReadLine());

N = Convert.ToInt32(Console.ReadLine());

if (X > Y)
{ 
    if (X > N)
    {
        Console.WriteLine("{0} наибольшее число ", X);
    }
    else
    {
        Console.WriteLine("{0} наибольшее число ", N);
    }
}
else if (Y > N)
{
    Console.WriteLine("{0} наибольшее число ", Y);
}
else
{
    Console.WriteLine("{0} наибольшее число ", N);
}
Console.ReadLine();

