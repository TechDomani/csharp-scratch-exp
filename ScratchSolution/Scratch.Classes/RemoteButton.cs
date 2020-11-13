using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Scratch.Classes
{
    public class RemoteButton
    {
        public RemoteButton(char label, int x, int y)
        {
            this.Label = label;
            this.X = x;
            this.Y = y;
        }
        public char Label { get; set; }
        public int X { get; set; }

        public int Y { get; set; }
    }
}
