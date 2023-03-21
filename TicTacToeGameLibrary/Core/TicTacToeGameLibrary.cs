using TicTacToeGameLibrary.Enums;
using TicTacToeGameLibrary.Interfaces;
using TicTacToeGameLibrary.Models;

namespace TicTacToeGameLibrary.Core
{
    public class TicTacToeGame : ITicTacToeGame
    {
        public Player player1;
        public Player player2;
        private List<PlayerGameInfo> gameTable;

        public TicTacToeGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            gameTable = new List<PlayerGameInfo>();
            LoggerLibrary.LoggerWrite($"TicTacToe Game. Player1: {this.player1.Name} ({this.player1.CharOnTable}) VS Player2: {this.player2.Name} ({this.player2.CharOnTable})");
        }

        /// <summary>
        /// Check is the game end and check is some player won
        /// </summary>
        /// <returns></returns>
        private bool CheckEndGame()
        {
            int[] arrayTemp = new int[] { 0, 1, 2 };
            bool response = true;
            if (
                gameTable.Where(x => x.player == player1 && x.playerGame.PositionX == 0 && arrayTemp.Contains(x.playerGame.PositionY)).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && x.playerGame.PositionX == 1 && arrayTemp.Contains(x.playerGame.PositionY)).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && x.playerGame.PositionX == 2 && arrayTemp.Contains(x.playerGame.PositionY)).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && x.playerGame.PositionY == 0 && arrayTemp.Contains(x.playerGame.PositionX)).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && x.playerGame.PositionY == 1 && arrayTemp.Contains(x.playerGame.PositionX)).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && x.playerGame.PositionY == 2 && arrayTemp.Contains(x.playerGame.PositionX)).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && ((x.playerGame.PositionX == 0 && x.playerGame.PositionY == 0) || (x.playerGame.PositionX == 1 && x.playerGame.PositionY == 1) || (x.playerGame.PositionX == 2 && x.playerGame.PositionY == 2))).ToList().Count == 3
                || gameTable.Where(x => x.player == player1 && ((x.playerGame.PositionX == 2 && x.playerGame.PositionY == 0) || (x.playerGame.PositionX == 1 && x.playerGame.PositionY == 1) || (x.playerGame.PositionX == 0 && x.playerGame.PositionY == 2))).ToList().Count == 3
                )
            {
                LoggerLibrary.LoggerWrite($"TicTacToe Game End. Player1: {this.player1.Name} ({this.player1.CharOnTable}) won!!!");
            }
            else if (
                gameTable.Where(x => x.player == player2 && x.playerGame.PositionX == 0 && arrayTemp.Contains(x.playerGame.PositionY)).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && x.playerGame.PositionX == 1 && arrayTemp.Contains(x.playerGame.PositionY)).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && x.playerGame.PositionX == 2 && arrayTemp.Contains(x.playerGame.PositionY)).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && x.playerGame.PositionY == 0 && arrayTemp.Contains(x.playerGame.PositionX)).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && x.playerGame.PositionY == 1 && arrayTemp.Contains(x.playerGame.PositionX)).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && x.playerGame.PositionY == 2 && arrayTemp.Contains(x.playerGame.PositionX)).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && ((x.playerGame.PositionX == 0 && x.playerGame.PositionY == 0) || (x.playerGame.PositionX == 1 && x.playerGame.PositionY == 1) || (x.playerGame.PositionX == 2 && x.playerGame.PositionY == 2))).ToList().Count == 3
                || gameTable.Where(x => x.player == player2 && ((x.playerGame.PositionX == 2 && x.playerGame.PositionY == 0) || (x.playerGame.PositionX == 1 && x.playerGame.PositionY == 1) || (x.playerGame.PositionX == 0 && x.playerGame.PositionY == 2))).ToList().Count == 3
                )
            {
                LoggerLibrary.LoggerWrite($"TicTacToe Game End. Player2: {this.player2.Name} ({this.player2.CharOnTable}) won!!!");
            }
            else if (gameTable.Count == 9)
            {
                LoggerLibrary.LoggerWrite($"TicTacToe Game End. anyone's won!!!");
            }
            else 
            {
                response = false;
            }
            
            return response;
        }

        /// <summary>
        /// Check if the correct player is sending information
        /// </summary>
        /// <param name="playerGameInfo"></param>
        /// <returns></returns>
        private bool CheckPlayerTurn(PlayerGameInfo playerGameInfo)
        {
            bool response = false;
            if (gameTable.Count < 1 && playerGameInfo.player != player1)
            {
                LoggerLibrary.LoggerWrite($"Player1 should be start the game");
            }
            else if (gameTable.Count > 0 && gameTable.Last().player == player1 && playerGameInfo.player == player1)
            {
                LoggerLibrary.LoggerWrite($"Is the turn of Player2 not Player1");
            }
            else if (gameTable.Count > 0 && gameTable.Last().player == player2 && playerGameInfo.player == player2)
            {
                LoggerLibrary.LoggerWrite($"Is the turn of Player1 not Player2");
            }
            else
                response = true;

            return response;
        }

        /// <summary>
        /// Check if the information of movement its valid
        /// </summary>
        /// <param name="playerGameInfo"></param>
        /// <returns></returns>
        private bool CheckMovement(PlayerGameInfo playerGameInfo) 
        {
            int[] arrayTemp = new int[] { 0, 1, 2 };
            bool response = false;
            if (!arrayTemp.Contains(playerGameInfo.playerGame.PositionX) || !arrayTemp.Contains(playerGameInfo.playerGame.PositionY))
                LoggerLibrary.LoggerWrite($"PositionX: {playerGameInfo.playerGame.PositionX} and/or PositionY: {playerGameInfo.playerGame.PositionY} are not in the range [0,1,2]");
            else if (gameTable.Where(x=>x.playerGame.PositionX == playerGameInfo.playerGame.PositionX && x.playerGame.PositionY == playerGameInfo.playerGame.PositionY).ToList().Count > 0)
                LoggerLibrary.LoggerWrite($"PositionX: {playerGameInfo.playerGame.PositionX} and PositionY: {playerGameInfo.playerGame.PositionY} was already used");
            else
                response = true;
            return response;
        }

        /// <summary>
        /// Insert a new position on the game 
        /// </summary>
        /// <param name="playerGameInfo"></param>
        public StatusGame InsertPosition(PlayerGameInfo playerGameInfo)
        {
            if (!CheckPlayerTurn(playerGameInfo))
            {
                return StatusGame.InvalidTurn;
            }
            if (!CheckMovement(playerGameInfo))
            {
                return StatusGame.InvalidMovement;
            }
            
            gameTable.Add(playerGameInfo);
            LoggerLibrary.LoggerWrite($"Player: {playerGameInfo.player.Name} insert: {playerGameInfo.player.CharOnTable} on PositionX:{playerGameInfo.playerGame.PositionX} and PositionY: {playerGameInfo.playerGame.PositionY} successfully");
            PrintTableGame();
            
            if (CheckEndGame())
            {
                return StatusGame.GameEnd;
            }

            return StatusGame.GameInProgress;
        }

        /// <summary>
        /// Printa Table Game on Console
        /// </summary>
        private void PrintTableGame()
        {
            char[,] tableGame = new char[3, 3] { {'-', '-', '-'}, { '-', '-', '-' }, { '-', '-', '-' } };
            foreach (PlayerGameInfo gameInfo in gameTable)
            {
                tableGame[gameInfo.playerGame.PositionY, gameInfo.playerGame.PositionX] = gameInfo.player.CharOnTable;
            }
            for (int i = 0; i < tableGame.GetLength(0); i++)
            {
                string row = string.Empty;
                for (int j = 0; j < tableGame.GetLength(1); j++)
                {
                    row += $"{tableGame[i, j]} ";
                }
                LoggerLibrary.LoggerWrite($"{row} ");
            }
        }
    }
}
