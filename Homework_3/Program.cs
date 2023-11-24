// Задача 3
int num;
    do
    {
        Console.Write("Введите число : ");
        num = Convert.ToInt32(Console.ReadLine());
        if ((10 > num)||(num > 99))
        {
            Console.WriteLine("Число не удовлетворяет условию");
        }
    }while((10 > num)||(num > 99));
int n1 = num / 10;
int n2 = num % 10;
if(n1 > n2)
   Console.WriteLine(n1);
else
   Console.WriteLine(n2);

