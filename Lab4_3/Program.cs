﻿NewMethod();

/*  Дано дійсні числа a, b, c. Знайти суму тих з них, які належать
    інтервалу [1, 10]. Числа оголосити в коді програми. Результат вивести
    на консоль.*/

static void NewMethod()
{
    int a = 1, b = 2, c = 11;
    int sum = 0;
    if (a >= 1 && a <= 10)
    {
        sum += a;
    }

    if (b >= 1 && b <= 10)
    {
        sum += b;
    }

    if (c >= 1 && c <= 10)
    {
        sum += c;
    }

    Console.WriteLine($"Сумма = {sum}");
}