using System;

namespace Csharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string consoleName;

            consoleName = "PS5";

            int yearsOut = 2;

            char firstInital = 'P';

            bool isOut = true;

            double consolePrice = 1000.5;

            decimal consoleWeight = 18.7m;

            Console.WriteLine($"Sony is dropping the ball on their {consoleName}. It's been out for {yearsOut} years and you still cant find one. It costs {consolePrice} amd weighs {consoleWeight} pounds.");

            Console.WriteLine("It is " + isOut + " is sold out and will not be back in stock anytime soon.");
        }
    }
}
