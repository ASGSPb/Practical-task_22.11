// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

// Console.WriteLine("Введите число не более 5 знаков");
// int num = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(10000, 100000);
int modul = Math.Abs ( num );
string array = Convert.ToString ( modul );

if ( array[0] == array[4] && array[1] == array[3] ) Console.WriteLine("Число "+ num + " число палиндром");
else Console.WriteLine("Число "+ num + " палиндромом НЕ является");
