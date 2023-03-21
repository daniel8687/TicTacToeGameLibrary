
namespace TicTacToeGameLibraryTest
{
    public class SetupCodeUnit : IDisposable
    {
        public Mock<Player> mockPlayer1;
        public Mock<Player> mockPlayer2;

        public SetupCodeUnit()
        {
            mockPlayer1 = new Mock<Player>();
            mockPlayer1.Object.Name = It.IsAny<string>();
            mockPlayer1.Object.CharOnTable = It.IsAny<char>();
            mockPlayer2 = new Mock<Player>();
            mockPlayer2.Object.Name = It.IsAny<string>();
            mockPlayer2.Object.CharOnTable = It.IsAny<char>();
        }

        public void Dispose()
        {
        }
    }
}
