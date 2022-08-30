// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.Write("Введите число: ");
int number = int.Parse(System.Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа {number} равен = {sqr1}");
