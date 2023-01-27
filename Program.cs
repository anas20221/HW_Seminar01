/* задача 2
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7, min = 5
a = 2 b = 10 -> max = 10, min = 2
*/
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
