/* ____________________________________
задача 2
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7, min = 5
a = 2 b = 10 -> max = 10, min = 2

Console.Write ("Please input first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Please input second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine("First number is " + num_1 + " greater then the second number" + num_2);
}
else
{
    Console.WriteLine("Second number is " + num_2 + " greater then the first number " + num_1);
}
_____________________________________________________
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write ("Please input first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Please input second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Please input second number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
   max = num_2; 
}
if (num_3 > max)
{
    max = num_3;
}
Console.WriteLine("The biggest number from these three is " + max);
______________________________________________
*/ 
/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.Write ("Please write a number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

if (num % 2 == 0)
{
    Console.WriteLine($"Number " + num + " is Even number");
}
else 
{
    Console.WriteLine($"Number " + num + " is Odd number");
}
*/