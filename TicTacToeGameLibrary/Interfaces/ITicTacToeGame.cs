using TicTacToeGameLibrary.Enums;
using TicTacToeGameLibrary.Models;

namespace TicTacToeGameLibrary.Interfaces
{
    public interface ITicTacToeGame
    {
        public StatusGame InsertPosition(PlayerGameInfo playerGameInfo);
    }
}
