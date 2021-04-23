using System;

namespace CircleArea
{
    class Program
    {

        public static void Print(string text,ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void Main()
        {
            double radius = 0;
            Print("=> Circle Area By Mohamed Moafa", ConsoleColor.DarkGreen);
            Console.WriteLine("".PadLeft(Console.BufferWidth,'-'));
            Console.Write("Enter Radius: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            radius = double.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine($"Circle area is = {radius*radius*Math.PI:f2}"); 
            Console.ReadKey();
        }
    }
}
