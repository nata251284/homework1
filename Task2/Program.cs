/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine();
int numberone = Convert.ToInt32(number1);

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine();
int numbertwo = Convert.ToInt32(number2);

Console.Write("Введите третье число: ");
string number3 = Console.ReadLine();
int numberthree = Convert.ToInt32(number3);

if(numberone > numbertwo && numberone > numberthree)
{
        Console.WriteLine("Максимальное число: "+numberone);
}
   
if(numbertwo > numberone && numbertwo > numberthree)
    {
        Console.WriteLine("Максимальное число: "+numbertwo);
    }
if(numberthree > numberone && numberthree > numbertwo)
    {
        Console.WriteLine("Максимальное число: "+numberthree);
    } 
if(numberone == numbertwo && numbertwo == numberthree)
{
 Console.WriteLine("Все числа равны");   
}
