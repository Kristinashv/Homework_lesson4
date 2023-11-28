// Задача 1

int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
int n = 0;
for (int i = 0; i < array.Length; i++)
{
    if((20 < array[i]) && (array[i] < 90))
    {
        n++;
    }
}
Console.WriteLine("количество = "+n);