// 

int[] arr = new int [10];
Random rand = new Random();
Console.Write("Массив случайных чисел 1 : ");
for(int i = 0; i < arr.Length ; i++)
{
    arr[i] = rand.Next(100,10000);
    Console.Write(arr[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < arr.Length/2 ; i++)
{
    int n = arr[i];
    arr[i] = arr[9-i];
    arr[9-i]=n;
}
Console.Write("Массив случайных чисел 2 : ");
for(int i = 0; i < arr.Length ; i++)
{
    Console.Write(arr[i]+" ");
}