NewMethod();

/*  Ввести з консолі два числа. Перевірити чи знаходяться
      вони в інтервалі [1,5] або [5,9]. Вивести на консоль повідомлення про
      результат порівняння (в якому інтервалі знаходиться кожне з чисел).*/

static void NewMethod()
{
   
    Console.WriteLine("Введіть a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть b: ");
    int b = int.Parse(Console.ReadLine());

    if (a >= 1 && a <= 5)
        Console.WriteLine("Число а інтервалі від 1 до 5");
    else Console.WriteLine("Число а за межами інтервалів");
    if (a > 5 && a <= 9)
        Console.WriteLine("Число а інтервалі від 5 до 9");
    else Console.WriteLine("Число а за межами інтервалів");
    if (b >= 1 && b <= 5)
        Console.WriteLine("Число b інтервалі від 1 до 5");
    else Console.WriteLine("Число b за межами інтервалів");
    if (b > 5 && b <= 9)
        Console.WriteLine("Число b інтервалі від 5 до 9");
    else Console.WriteLine("Число b за межами інтервалів");

}