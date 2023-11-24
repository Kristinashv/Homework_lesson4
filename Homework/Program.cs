// Задача 1

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if ((a % 7 == 0) && (a % 23 == 0))
    Console.WriteLine("да");

else 
    Console.WriteLine("нет");