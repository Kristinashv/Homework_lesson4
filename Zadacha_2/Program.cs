// Zadacha 2

int[] arr = new int [10];
Random rand = new Random();
Console.Write("Массив случайных чисел : ");
for(int i = 0; i < arr.Length ; i++)
{
    arr[i] = rand.Next(100,1000);
    Console.Write(arr[i]+" ");
}
Console.WriteLine();
int n = 0;
for(int i = 0; i < arr.Length ; i++)
{
    if (arr[i] % 2 == 0)
    {
        n++;
    }
}
Console.WriteLine("Количество четных чисел = " + n);


