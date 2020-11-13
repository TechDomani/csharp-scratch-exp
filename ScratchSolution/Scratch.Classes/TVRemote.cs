using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace Scratch.Classes
{
    public class TVRemote
    {
        // List of RemoteButtons 
        // Starting position
        // Starting number of moves = 0
        // Get to next letter
        // Increment number of move
        // Repeat process from new starting position
        public TVRemote ()
        {
            this.MakeButtons();
        }

        private List<RemoteButton> buttons = new List<RemoteButton>();

        private void MakeButtons()
        {
            this.buttons.Add(new RemoteButton('a', 1, 1));
            this.buttons.Add(new RemoteButton('b', 2, 1));
            this.buttons.Add(new RemoteButton('c', 3, 1));
            this.buttons.Add(new RemoteButton('f', 1, 2));
            this.buttons.Add(new RemoteButton('g', 2, 2));
            this.buttons.Add(new RemoteButton('h', 3, 2));
        }

        public int FindNumberOfMovesForWord(string word)
        {
            int totalMoves = 0;
            var currentButton = this.buttons[0];
            foreach (var letter in word)
            {
                totalMoves += this.MoveLetter(currentButton, letter);
                Console.WriteLine(letter);
            }
            return totalMoves;
        }

        private int MoveLetter(RemoteButton currButton, char end)
        {
            int numOfMoves = 0;
            foreach (var button in this.buttons)
            {
                if (button.Label == end)
                {
                    int newX = button.X;
                    int newY = button.Y;
                    numOfMoves = Math.Abs(newX - currButton.X);
                    numOfMoves += Math.Abs(newY - currButton.Y);
                    numOfMoves += 1;
                    currButton = button;
                }
            }
            return numOfMoves;
        }

        public int MoveASingleLetter(int x, int y, char end)
        {
            int numOfMoves = 0;
            foreach (var button in this.buttons)
            {
                if (button.Label == end)
                {
                    int newX = button.X;
                    int newY = button.Y;
                    numOfMoves = Math.Abs(newX - x);
                    numOfMoves += Math.Abs(newY - y);
                    numOfMoves += 1;
                }
            }
            return numOfMoves;
        }

    }
}
