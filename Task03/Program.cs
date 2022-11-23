// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());
double first = 1;

while (  first <= N )
{
    Console.Write($""+ Math.Pow(first, 3) + ", ");
    first++;
}


