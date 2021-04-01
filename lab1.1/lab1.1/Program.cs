using System;

namespace lab1
{
    class Program
    {
        delegate int avarage(int b, int c, int d);
        static void Main(string[] args)
        {
            avarage Avarage = delegate (int b, int c, int d)
            {
                return (b + c + d) / 3;
            };

            int g = Avarage(5, 71, 19);
            Console.WriteLine(g);
            Console.Read();
        }
    }
}
