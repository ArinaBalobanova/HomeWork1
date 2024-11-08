using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task14();
    }

    // Задание 1. Вывести на экран число e с точностью до десятых
    static void Task1()
    {
        Console.WriteLine("(1)");
        double e = Math.E; // Основание натурального логарифма
        Console.WriteLine($"Число e с точностью до десятых: {e:F1}");
        Console.WriteLine();
    }

    //Задание 2. Вывести на экран числа 50 и 10 одно под другим
    static void Task2()
    {
        Console.WriteLine("(2)");
        Console.WriteLine(50);
        Console.WriteLine(10);
        Console.WriteLine();
    }

    // Задание 3. Вывод на экран «столбиком» четырех любых чисел
    static void Task3()
    {
        Console.WriteLine("(3)");
        int x3 = 18;
        int y3 = 4;
        int z3 = 51;
        int w3 = 33;

        Console.WriteLine(x3);
        Console.WriteLine(y3);
        Console.WriteLine(z3);
        Console.WriteLine(w3);
        Console.WriteLine();
    }

    // Задание 4. Пользователь вводит число. Выводим на экран число, которое больше введенного на 10
    static void Task4()
    {
        Console.WriteLine("(4)");
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number + 10; // Увеличиваем число на 10
        Console.WriteLine(result);
        Console.WriteLine();
    }

    // Задание 5. Дана сторона квадрата. Найти его периметр
    static void Task5()
    {
        Console.WriteLine("(5)");

        Console.Write("Введите длину стороны квадрата: ");
        double side = Convert.ToDouble(Console.ReadLine());
        double P = 4 * side; // Периметр квадрата
        Console.WriteLine(P);
    }

    // Задание 6.Дан радиус окружности. Найти длину окружности и площадь круга.
    static void Task6()
    {
        Console.WriteLine("(6)");

        Console.Write("Введите радиус окружности: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double C = 2 * Math.PI * r;// Рассчитать длину окружности (C = 2 * π * r)
        double S = Math.PI * r * r;// Рассчитать площадь круга (c = π * r^2)
        Console.WriteLine($"Длина окружности: {C:F2}");
        Console.WriteLine($"Площадь круга: {S :F2}");

    }

    //Задание 7.Найти значение y=cos(x)
    static void Task7()
    {
        Console.WriteLine("(7)");

        Console.Write("Введите значение x (в градусах): ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Math.Cos(x * Math.PI / 180); // Преобразование в радианы
        Console.WriteLine($"y = cos(x) = {y}");
        Console.WriteLine();
    }

    // Задание 8.Даны основания и высота равнобедренной трапеции. Найти ее периметр.
    static void Task8()
    {
        Console.WriteLine("(8)");
        Console.Write("Введите длину первого основания трапеции: ");
        double a8 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину второго основания трапеции: ");
        double b8 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту трапеции: ");
        double h8 = Convert.ToDouble(Console.ReadLine());

        double side = Math.Sqrt(Math.Pow((b8 - a8) / 2, 2) + Math.Pow(h8, 2));// Для равнобедренной трапеции
        double P = a8 + b8 + 2 * side; // Периметр трапеции
        Console.WriteLine(P);
        Console.WriteLine();
    }

    //9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
    static void Task9()
    {
        Console.WriteLine("(9)");
        Console.Write("Введите стоимость 1 кг конфет: ");
        double priceCandy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите стоимость 1 кг печенья: ");
        double priceCookie = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите стоимость 1 кг яблок: ");
        double priceApple = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество килограммов конфет(x): ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите количество килограммов печенья(y): ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите количество килограммов яблок(z): ");
        double z = Convert.ToDouble(Console.ReadLine());

        double N = (x * priceCandy) + (y * priceCookie) + (z * priceApple);
        Console.WriteLine(N);
        Console.WriteLine();
    }

    //10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май" (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:Мир Труд Май
    static void Task10()
    {
        Console.WriteLine("(10)");
        Console.WriteLine("Мир Труд Май");
        Console.WriteLine("Мир");
        Console.WriteLine("\t\t\tТруд");
        Console.WriteLine("\t\t\t\t\t\t\tМай");
    }

    //14. Составить программу вывода на экран следующей информации: 2 кг 13 17
    static void Task14()
    {
        Console.WriteLine("(14)");
        Console.WriteLine("2 кг");
        Console.WriteLine("13 17");
    }
}
