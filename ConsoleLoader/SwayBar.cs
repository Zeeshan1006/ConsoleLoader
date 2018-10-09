using System;
using System.Text;

namespace ConsoleLoader
{
    public class SwayBar : Bar
    {
        string bar;
        string pointer;
        readonly string blankPointer;
        int counter;
        Direction currdir;

        enum Direction
        {
            Right,
            Left
        };

        public SwayBar() : base()
        {
            bar = "|                         |";
            pointer = "***";
            blankPointer = BlankPointer();
            currdir = Direction.Right;
            counter = 1;
        }

        private string BlankPointer()
        {
            StringBuilder blank = new StringBuilder();
            for (int count = 0; count < pointer.Length; count++)
                blank.Append(" ");
            return blank.ToString();
        }

        private void ClearBar()
        {
            bar = bar.Replace(pointer, blankPointer);
        }

        private void PlacePointer(int start, int end)
        {
            ClearBar();
            bar = bar.Remove(start, end);
            bar = bar.Insert(start, pointer);
        }

        public override void Step()
        {
            if (currdir == Direction.Right)
            {
                PlacePointer(counter, pointer.Length);
                counter++;
                if (counter + pointer.Length == bar.Length)
                    currdir = Direction.Left;
            }
            else
            {
                PlacePointer(counter - pointer.Length, pointer.Length);
                counter--;
                if (counter == pointer.Length)
                    currdir = Direction.Right;
            }
            Console.Write(this.bar + "\r");
        }
    }
}
