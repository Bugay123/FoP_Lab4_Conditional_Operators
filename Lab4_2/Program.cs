NewMethod();

/*Обчислити значення в функції в т.x. Значення x ввести з консолі.
    Результат вивести на консоль.
    Функція F задається таким чином:
    F(x) = sin^2 x , x>0
    F(x) = 1 + 2sinx, x<= 0*/

static void NewMethod()
{
    Console.WriteLine("Введіть x: ");
    double x = double.Parse(Console.ReadLine());
    double y = (x > 0) ? Math.Pow(Math.Sin(x), 2) : 1 + 2 * Math.Sin(x);

    Console.WriteLine($"x = {x}, y = {y}");
}