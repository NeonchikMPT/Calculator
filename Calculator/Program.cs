using System;

class Program
{
    static void Main()
    {
        int f = 1;
        int operation;
        bool Stop = false;
        double a;
        double b;
        while (Stop == false)
        {
            Console.WriteLine(' ');
            Console.WriteLine(@"Выберите арифметическое действие:
- Сложение (введите 1)
- Вычитание (введите 2)
- Умножение (введите 3)
- Деление (введите 4)
- Возведение числа в степень (введите 5)
- Корень (введите 6)
- Найти 1 процент от числа (введите 7)
- Факториал (введите 8)
- Выход (введите 9)");
            operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine("введите число ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("введите число ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"результат {a + b}");
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("введите число ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("введите число ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"результат {a - b}");
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("введите число ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("введите число ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"результат {a * b}");
                        break;

                    }
                case 4:
                    {
                        Console.WriteLine("введите число ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("введите число ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"результат {a / b}");
                        break;

                    }
                case 5:
                    {
                        Console.WriteLine("Введите число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень, в которую хотите возвести число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Pow(a, b));
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Введите число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(a));
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("введите число ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"результат {a / 100}");
                        break;

                    }
                case 8:
                    {
                        Console.WriteLine("Введите число");
                        a = Convert.ToDouble(Console.ReadLine());
                        int factorial = 1;
                        for (int i = 2; i <= a; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                        break;
                    }
                case 9:
                    {
                        Stop = true;
                        break;
                    }
            }
        }
    }
}