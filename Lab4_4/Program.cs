NewMethod();

/*  Є три точки на площині, задані координатами A(x1, y1),
    B(x2, y2), C(x3, y3). Визначити, чи утворюють вони трикутник. Якщо
    утворюють, визначити чи є трикутник рівностороннім.*/

static void NewMethod()
{
    double x1 = 1, y1 = 1;
    double x2 = 2, y2 = 2;
    double x3 = 3, y3 = 3;
    double a = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
    double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
    double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Це трикутник");
        if (a == b && a == c)
            Console.WriteLine("Це рівносторонній трикутник");
    }
    else
        Console.WriteLine("Це не трикутник");
}
