using System;
using System.Threading;
using ConsoleLoader;

namespace StatusBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar bar;
            bar = new AnimatedBar();
            int wait = 100;
            int end = 50;

            Test(bar, wait, end);

            bar = new SwayBar();
            Test(bar, wait, end);

            Console.ReadKey();
        }

        public static void Test(Bar bar, int wait, int end)
        {
            bar.PrintMessage("Loading...");
            for (int cont = 0; cont < end; cont++)
            {
                bar.Step();
                Thread.Sleep(wait);
            }
            bar.PrintMessage("Finished");
        }
    }
}
