using System;

namespace ConsoleLoader
{
    public abstract class Bar
    {
        public Bar()
        {
                
        }

        /// <summary>
        /// Status Message
        /// </summary>
        /// <param name="message"></param>
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Step();
    }
}
