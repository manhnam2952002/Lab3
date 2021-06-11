using System;

namespace Computer
{
    public class ListBox: Window
    {
        public ListBox(int top, int left, string standAloneListBox) : base(top, left)
        {
            listBoxContents = listBoxContents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
        }

        private string listBoxContents;
    }
}