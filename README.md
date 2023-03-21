# TicTacToeGameLibrary
TicTacToe Game Library

# How Call TicTacToeGameLibrary  
Player player1 = new Player() { Name = "Player1", CharOnTable = 'X'};  
Player player2 = new Player() { Name = "Player2", CharOnTable = 'O' };  
ITicTacToeGame ticTacToeLibrary = new TicTacToeGame(player1, player2);  
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player2, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });  
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player1, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player1, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player2, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player2, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player1, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player2, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player1, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2 } });
ticTacToeLibrary.InsertPosition(new PlayerGameInfo() { player = player2, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1 } });

# Log
You can see the log over path:
{executionPath}\Logger\Logs.txt
