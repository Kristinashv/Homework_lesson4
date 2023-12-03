// Zadacha 1

string num;  
    bool key = false;
    do
    {
        Console.Write("Введите двухзначное число : ");
        num = Console.ReadLine();
        if (num == "q")
        {
            Console.WriteLine("Введен символ q");
        }
        int num1 = Int32.Parse(num);
        int n1 = num1/10;
        int n2 = num1%10;
        if ((n2+n1)%2==0)
        {
            Console.Write("Введено число сумма цифр которых делиться на 2");
            key = true;
        }
    }while((num == "q")||(key == false));
