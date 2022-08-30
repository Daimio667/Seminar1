// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
Console.Write("Введите число: ");
int numberA = int.Parse(System.Console.ReadLine());
Console.Write("Введите число: ");
int numberB = int.Parse(System.Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.Write("Первое число является квадратом второго числа");
}

else
{
    Console.Write("Первое число не является квадратом второго числа");
}
