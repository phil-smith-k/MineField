using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClasses
{
    public class Grid
    {
        private GridLine _gridLine = new GridLine();
        public int Size { get; private set; }
        public Grid(int size)
        {
            this.Size = size;
        }
        public string GenerateGrid(int size)
        {
            string result = "";
            for (int i = 1; i <= size + 4; i++)
            {
                if (i % 2 == 0)
                {
                    result += _gridLine.GenerateEvenLine(size) + "\n";
                }
                else
                {
                    result += _gridLine.GenerateOddLine(size) + "\n";
                }
            }
            return result;
        }
        public string GenerateGridForPlayerOne(int x, int y)
        {
            string result = "";
            for (int i = 1; i <= this.Size + (this.Size + 1); i++)
            {
                if (i == this.Size + (this.Size + 1))
                {
                    result += _gridLine.GenerateOddLine(this.Size) + "\n";
                }
                else if (i == (y * 2) + 2)
                {
                    result += _gridLine.GenerateEvenLineWithOne(this.Size, x) + '\n';
                }
                else if (i % 2 == 0)
                {
                    result += _gridLine.GenerateEvenLine(this.Size) + "\n";
                }
                else
                {
                    result += _gridLine.GenerateOddLine(this.Size) + "\n";
                }
            }
            return result;
        }
        public string GenerateGridForPlayerTwo(int x, int y)
        {
            string result = "";
            for (int i = 1; i <= this.Size + (this.Size + 1); i++)
            {
                if (i == this.Size + (this.Size + 1))
                {
                    result += _gridLine.GenerateOddLine(this.Size) + "\n";
                }
                else if (i == (y * 2) + 2)
                {
                    result += _gridLine.GenerateEvenLineWithTwo(this.Size, x) + '\n';
                }
                else if (i % 2 == 0)
                {
                    result += _gridLine.GenerateEvenLine(this.Size) + "\n";
                }
                else
                {
                    result += _gridLine.GenerateOddLine(this.Size) + "\n";
                }
            }
            return result;
        }
        public string GenerateGridForBothPlayers(Player playerOne, Player playerTwo)
        {
            string result = "";
            if (playerOne.PositionY == playerTwo.PositionY)
            {
                for (int i = 1; i <= this.Size + (this.Size + 1); i++)
                {
                    if (i == this.Size + (this.Size + 1))
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                    else if (i == (playerTwo.PositionY * 2) + 2)
                    {
                        result += _gridLine.GenerateEvenLineWithOneAndTwo(this.Size, playerOne.PositionX, playerTwo.PositionX) + '\n';
                    }
                    else if (i % 2 == 0)
                    {
                        result += _gridLine.GenerateEvenLine(this.Size) + "\n";
                    }
                    else
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                }
            }
            else
            {
                for (int i = 1; i <= this.Size + (this.Size + 1); i++)
                {
                    if (i == this.Size + (this.Size + 1))
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                    else if (i == (playerTwo.PositionY * 2) + 2)
                    {
                        result += _gridLine.GenerateEvenLineWithTwo(this.Size, playerTwo.PositionX) + '\n';
                    }
                    else if (i == (playerOne.PositionY * 2) + 2)
                    {
                        result += _gridLine.GenerateEvenLineWithOne(this.Size, playerOne.PositionX) + '\n';
                    }
                    else if (i % 2 == 0)
                    {
                        result += _gridLine.GenerateEvenLine(this.Size) + "\n";
                    }
                    else
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                }
            }
            return result;
        }
        public string GenerateGridForBothPlayers(int xOne, int yOne, int xTwo, int yTwo)
        {
            string result = "";
            if (yOne == yTwo)
            {
                for (int i = 1; i <= this.Size + (this.Size + 1); i++)
                {
                    if (i == this.Size + (this.Size + 1))
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                    else if (i == (yTwo * 2) + 2)
                    {
                        result += _gridLine.GenerateEvenLineWithOneAndTwo(this.Size, xOne, xTwo) + '\n';
                    }
                    else if (i % 2 == 0)
                    {
                        result += _gridLine.GenerateEvenLine(this.Size) + "\n";
                    }
                    else
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                }
            }
            else
            {
                for (int i = 1; i <= this.Size + (this.Size + 1); i++)
                {
                    if (i == this.Size + (this.Size + 1))
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                    else if (i == (yTwo * 2) + 2)
                    {
                        result += _gridLine.GenerateEvenLineWithTwo(this.Size, xTwo) + '\n';
                    }
                    else if (i == (yOne * 2) + 2)
                    {
                        result += _gridLine.GenerateEvenLineWithOne(this.Size, xOne) + '\n';
                    }
                    else if (i % 2 == 0)
                    {
                        result += _gridLine.GenerateEvenLine(this.Size) + "\n";
                    }
                    else
                    {
                        result += _gridLine.GenerateOddLine(this.Size) + "\n";
                    }
                }
            }
            return result;
        }
    }
}
