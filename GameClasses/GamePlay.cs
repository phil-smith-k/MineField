using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClasses
{
    public class GamePlay
    {
        public GamePlay(int size)
        {
            this.GameBoard = new Grid(size);
            this.PlayerOne = new Player(0, 0);
            this.PlayerTwo = new Player(size - 1, size - 1);
        }
        public Grid GameBoard { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public List<Mine> Mines { get; set; }
        public string GenerateNewBoard()
        {
            return this.GameBoard.GenerateGridForBothPlayers(this.PlayerOne, this.PlayerTwo);
        }
        public void MovePlayerOne()
        {
            bool isMoving = true;
            while (isMoving)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (this.PlayerOne.PositionY - 1 >= 0)
                        {
                            this.PlayerOne.PositionY -= 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    case ConsoleKey.DownArrow:
                        if (this.PlayerOne.PositionY + 1 <= this.GameBoard.Size - 1)
                        {
                            this.PlayerOne.PositionY += 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (this.PlayerOne.PositionX - 1 >= 0)
                        {
                            this.PlayerOne.PositionX -= 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    case ConsoleKey.RightArrow:
                        if (this.PlayerOne.PositionX + 1 <= this.GameBoard.Size - 1)
                        {
                            this.PlayerOne.PositionX += 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    default:
                        break;
                } 
            }
        }
        public void MovePlayerTwo()
        {
            bool isMoving = true;
            while (isMoving)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (this.PlayerTwo.PositionY - 1 >= 0)
                        {
                            this.PlayerTwo.PositionY -= 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    case ConsoleKey.DownArrow:
                        if (this.PlayerTwo.PositionY + 1 <= this.GameBoard.Size - 1)
                        {
                            this.PlayerTwo.PositionY += 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (this.PlayerTwo.PositionX - 1 >= 0)
                        {
                            this.PlayerTwo.PositionX -= 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    case ConsoleKey.RightArrow:
                        if (this.PlayerTwo.PositionX + 1 <= this.GameBoard.Size - 1)
                        {
                            this.PlayerTwo.PositionX += 1;
                            isMoving = false;
                        }
                        else
                            isMoving = true;
                        break;
                    default:
                        break;
                }
            }
        }
        public bool StillPlaying()
        {
            if(this.PlayerOne.GetCoordinates() == $"{this.GameBoard.Size - 1} {this.GameBoard.Size - 1}" || this.PlayerTwo.GetCoordinates() == $"0 0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool DidPlayersActivateMine(Player player, Player playerTwo)
        {
            bool isMine = false;
            foreach (Mine mine in this.Mines)
            {
                if (player.GetCoordinates() == mine.GetCoordinates() || playerTwo.GetCoordinates() == mine.GetCoordinates())
                {
                    isMine = true;
                }
                else
                {
                    isMine =false;
                }
            }
            return isMine;
        }
    }
}
