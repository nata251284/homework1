﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число: ");
string numberstr = Console.ReadLine();
int number = Convert.ToInt32(numberstr);

if (number%2 == 0)
{
    Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");  
}