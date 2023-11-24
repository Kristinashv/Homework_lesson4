// Задача 2

int x , y;
    do
    {
        Console.Write("Введите x : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y : "); 
        y = Convert.ToInt32(Console.ReadLine());
        if ((x==0)||(y==0))
        {
            Console.WriteLine("Введите целые числа для обеих переменных");
        }
    }while((x==0)||(y==0));
    if ((x>0)&&(y>0))
    {
      Console.Write("1 четверть");
    }
    if ((x<0)&&(y>0))
    {
      Console.Write("2 четверть");
    }
    if ((x<0)&&(y<0))
    {
      Console.Write("3 четверть");
    }
    if ((x>0)&&(y<0))
    {
      Console.Write("4 четверть");
    }

