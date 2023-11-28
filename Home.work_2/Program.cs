// Задача 2

    Random rand = new Random();
    int[] array = new int [10];
    for (int i = 0; i < array.Length ; i++)
    {
        array[i] = rand.Next(100);
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
    int n = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i] % 2 == 0)
        {
            n++;
        }
    }
    Console.Write("количество четныx чисел = " + n);
    

