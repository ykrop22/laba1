using System;

namespace ConsoleApp42
{
    class Program
    {
        delegate float NumHandler(float num1, float num2);
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию:1-Сумма; 2-Разница; 3-Умножение; 4-Деление");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            float y = float.Parse(Console.ReadLine());


            int caseSwitch = i;
            switch (caseSwitch)
            {
                case 1:
                    NumHandler Add = (x, y) => x + y;
                    Console.WriteLine("Сумма чисел:");
                    Console.WriteLine(Add(x, y));
                    break;
                case 2:
                    NumHandler Sub = (x, y) => x - y;
                    Console.WriteLine("Разница чисел:");
                    Console.WriteLine(Sub(x, y));
                    break;
                case 3:
                    NumHandler Mul = (x, y) => x * y;
                    Console.WriteLine("Результат умножения чисел:");
                    Console.WriteLine(Mul(x, y));
                    break;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Ошибка!!! На ноль делить нельзя!!!");
                        break;
                    }
                    NumHandler Div = (x, y) => x / y;
                    Console.WriteLine("Результат деления чисел:");
                    Console.WriteLine(Div(x, y));
                    break;


            }
        }
    }
}
