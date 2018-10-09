using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLoader
{
    public class AnimatedBar : Bar
    {
        readonly List<string> animation;
        int counter;

        public AnimatedBar() : base()
        {
            animation = new List<string> { "/", "-", @"\", "|" };
            counter = 0;
        }

        public override void Step()
        {
            Console.Write(animation[counter] + "\b");

            counter++;

            if(counter == animation.Count)
            {
                counter = 0;
            }
        }
    }
}
