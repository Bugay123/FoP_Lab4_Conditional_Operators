NewMethod();

/*  Написати програму, яка в залежності від порядкового номера місяця
    (1,2,...12) виводить на екран пору року (зима, весна....).*/

static void NewMethod()
{
    string x = null;
    Console.WriteLine("Введіть місяця: ");
    int number = int.Parse(Console.ReadLine());
    if (number >= 3 && number <= 5)
    {
        x = "Весна";
    }
    else if (number >= 6 && number <= 8)
    {
       x = "Літо";
    }
    else if (number >= 9 && number <= 11)
    {
        x = "Осінь";
    }
    else if (number >= 1 && number <= 2 || number == 12)
    {
        x = "Зима";
    }

    Console.WriteLine($"{number} - це місяць {x}");

    //Варіант 2

    Console.WriteLine("Введіть місяця: ");
   // int number = int.Parse(Console.ReadLine());
    switch(number){
        case 1:
            Console.WriteLine($"{number} - це місяць зими");
            break;
        case 2:
            Console.WriteLine($"{number} - це місяць зими");
            break;
        case 3:
            Console.WriteLine($"{number} - це місяць весни");
            break;
        case 4:
            Console.WriteLine($"{number} - це місяць весни");
            break;
        case 5:
            Console.WriteLine($"{number} - це місяць весни");
            break;
        case 6:
            Console.WriteLine($"{number} - це місяць літа");
            break;
        case 7:
            Console.WriteLine($"{number} - це місяць літа");
            break;
        case 8:
            Console.WriteLine($"{number} - це місяць літа");
            break;
        case 9:
            Console.WriteLine($"{number} - це місяць осені");
            break;
        case 10:
            Console.WriteLine($"{number} - це місяць осені");
            break;
        case 11:
            Console.WriteLine($"{number} - це місяць осені");
            break;
        case 12:
            Console.WriteLine($"{number} - це місяць зими");
            break;
    }
}

