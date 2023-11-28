// Задача 3

double[] array = new double[10];
    Random rand = new Random();
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * 100;
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
    double max = array[0];
    double min = array[0];
    for (int i = 0 ; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    double ans = max - min; 
    Console.WriteLine("Answer = " + ans);