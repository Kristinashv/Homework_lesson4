// Задача 4

Console.WriteLine("Введите число ");
    int N;
    int deg = 0;
    N = Convert.ToInt32(Console.ReadLine());
    for (int i = N ; i != 0 ; i = i/10)
    {
        deg++;
    }
    string str = "";
    for (int i = 0 ; i < deg ; i++)
    {
        double N1 = Math.Floor(N/Math.Pow(10,deg-i-1));
        str = str + Convert.ToString(N1);
        if (deg - i != 1)
        {
            str = str + ",";
        }
        N = Convert.ToInt32(N % Math.Pow(10,deg-i-1));
    }
    Console.Write(str);
