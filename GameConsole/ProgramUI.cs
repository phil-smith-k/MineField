using GameClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameConsole
{
    class ProgramUI
    {
        private GamePlay _gamePlay;
        public void Run()
        {
            LengthOfGameSetting();
            PopulateMines();
            while (_gamePlay.StillPlaying())
            {
                PlayerOneTurn();
                if (_gamePlay.StillPlaying())
                {
                    PlayerTwoTurn();
                }
                if(_gamePlay.DidPlayersActivateMine(_gamePlay.PlayerOne, _gamePlay.PlayerTwo))
                {
                    break;
                }
            }
            GameOver();
        }
        private void PlayerOneTurn()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_gamePlay.GenerateNewBoard());
            Console.WriteLine("Player One");
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\MineField.txt").ToList().ForEach(c => Console.WriteLine(c));


            _gamePlay.MovePlayerOne();

            Console.Clear();
            Console.WriteLine(_gamePlay.GenerateNewBoard());
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\MineField.txt").ToList().ForEach(c => Console.WriteLine(c));
        }
        private void PlayerTwoTurn()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_gamePlay.GenerateNewBoard());
            Console.WriteLine("Player Two");
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\MineField.txt").ToList().ForEach(c => Console.WriteLine(c));

            _gamePlay.MovePlayerTwo();

            Console.Clear();
            Console.WriteLine(_gamePlay.GenerateNewBoard());
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\MineField.txt").ToList().ForEach(c => Console.WriteLine(c));
        }
        private void PlayerOneWon()
        {
            Console.Clear();
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\PlayerOne.txt").ToList().ForEach(c => Console.WriteLine(c));
            Console.ReadLine();
        }
        private void PlayerTwoWon()
        {
            Console.Clear();
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\PlayerTwo.txt").ToList().ForEach(c => Console.WriteLine(c));
            Console.ReadLine();
        }
        private void PopulateMines()
        {
            List<Mine> mines = new List<Mine>();
            Random rand = new Random();
            for (int i = 0; i < this._gamePlay.GameBoard.Size - 2; i++)
            {
                mines.Add(new Mine(rand.Next(0, this._gamePlay.GameBoard.Size - 1), rand.Next(0, this._gamePlay.GameBoard.Size - 1)));
            }
            this._gamePlay.Mines = mines;
        }
        private void GameOver()
        {
            if (_gamePlay.DidPlayersActivateMine(_gamePlay.PlayerOne, _gamePlay.PlayerTwo))
            {
                Console.Clear();
                File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\GameOver.txt").ToList().ForEach(c => Console.WriteLine(c));
                Console.ReadLine();
            }
            else
            {
                if(Console.ForegroundColor == ConsoleColor.Red)
                {
                    PlayerOneWon();
                }
                else
                {
                    PlayerTwoWon();
                }
            }
        }
        private void LengthOfGameSetting()
        {
            File.ReadAllLines(@"C:\Users\pksmi\Documents\PersonalProjects\ConsoleGame\MineField.txt").ToList().ForEach(c => Console.WriteLine(c));
            Console.WriteLine("Choose a setting:\n\n" +
                "1) Short\n" +
                "2) Medium\n" +
                "3) Long\n");
            ConsoleKeyInfo userInput = Console.ReadKey();
            switch (userInput.Key)
            {
                case ConsoleKey.D1:
                    _gamePlay = new GamePlay(5);
                    break;
                case ConsoleKey.D2:
                    _gamePlay = new GamePlay(8);
                    break;
                case ConsoleKey.D3:
                    _gamePlay = new GamePlay(11);
                    break;
                default:
                    Console.Clear();
                    LengthOfGameSetting();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Generating game board, please wait...");
            Thread.Sleep(3000);
        }
    }
}
