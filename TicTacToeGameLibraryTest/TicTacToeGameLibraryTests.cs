
namespace TicTacToeGameLibraryTest
{
    public class TicTacToeGameLibraryTests : IClassFixture<SetupCodeUnit>
    {
        private readonly SetupCodeUnit _setupCodeUnit;

        public TicTacToeGameLibraryTests(SetupCodeUnit setupCodeUnit)
        {
            _setupCodeUnit = setupCodeUnit;
        }

        [Fact]
        public void CheckEndGame_TestPlayerWon()
        {
            List<List<PlayerGameInfo>> winScenarios = new List<List<PlayerGameInfo>>()
            {
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} }
                }
                ,
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} }
                }
                ,
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} }
                },
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 3, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 3, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 3, PositionY = 1} }
                }
            };

            foreach (var item in winScenarios)
            {
                TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
                FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
                field.SetValue(ticTacToeGame, item);
                MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckEndGame", BindingFlags.NonPublic | BindingFlags.Instance);
                object[] parameters = {};
                object result = methodInfo.Invoke(ticTacToeGame, parameters);
                Assert.True((bool)result);
            }
        }

        [Fact]
        public void CheckEndGame_TestPlayerNotWon()
        {
            List<List<PlayerGameInfo>> winScenarios = new List<List<PlayerGameInfo>>()
            {
                new List<PlayerGameInfo>()
                {
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 3, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 3, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                    new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} },
                }
            };

            foreach (var item in winScenarios)
            {
                TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
                FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
                field.SetValue(ticTacToeGame, item);
                MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckEndGame", BindingFlags.NonPublic | BindingFlags.Instance);
                object[] parameters = { };
                object result = methodInfo.Invoke(ticTacToeGame, parameters);
                Assert.False((bool)result);
            }
        }

        [Fact]
        public void CheckPlayerTurn_CheckIfPlayer1StartOk()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, new List<PlayerGameInfo>());
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckPlayerTurn", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object , playerGame = It.IsAny<PlayerGame>() } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.True((bool)result);
        }

        [Fact]
        public void CheckPlayerTurn_CheckIfPlayer1StartFail()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, new List<PlayerGameInfo>());
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckPlayerTurn", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = It.IsAny<PlayerGame>() } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void CheckPlayerTurn_CheckIfPlayerTurnOk()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = It.IsAny<PlayerGame>() }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckPlayerTurn", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = It.IsAny<PlayerGame>() } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.True((bool)result);
        }

        [Fact]
        public void CheckPlayerTurn_CheckIfPlayerTurnFail()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = It.IsAny<PlayerGame>() }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckPlayerTurn", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = It.IsAny<PlayerGame>() } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void CheckMovement_WithEmptyGameOk()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, new List<PlayerGameInfo>());
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.True((bool)result);
        }

        [Fact]
        public void CheckMovement_WithNotEmptyGameOk()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.True((bool)result);
        }

        [Fact]
        public void CheckMovement_WithEmptyGamePositionXFailed()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, new List<PlayerGameInfo>());
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = -1, PositionY = 0 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void CheckMovement_WithNotEmptyGamePositionXFailed()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = 4, PositionY = 0 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void CheckMovement_WithEmptyGamePositionYFailed()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, new List<PlayerGameInfo>());
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = 0, PositionY = -1 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void CheckMovement_WithNotEmptyGamePositionYFailed()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = 0, PositionY = 4 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void CheckMovement_WithNotEmptyGameAlreadyUsedFailed()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            MethodInfo methodInfo = typeof(TicTacToeGame).GetMethod("CheckMovement", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new PlayerGameInfo() { player = It.IsAny<Player>(), playerGame = new PlayerGame() { PositionX = 0, PositionY = 1 } } };
            object result = methodInfo.Invoke(ticTacToeGame, parameters);
            Assert.False((bool)result);
        }

        [Fact]
        public void InsertPosition_WithEmptyGameOk()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
            Assert.Equal(StatusGame.GameInProgress, response);
            
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(1, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithNotEmptyGameOk()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);
            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
            Assert.Equal(StatusGame.GameInProgress, response);

            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(2, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithEmptyGameWrongTurnFailed()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
            Assert.Equal(StatusGame.InvalidTurn, response);

            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(0, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithNotEmptyGameWrongTurnFailed()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);

            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0 } });
            Assert.Equal(StatusGame.InvalidTurn, response);

            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(1, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithEmptyGameWrongMovementFailed()
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = -4, PositionY = 5 } });
            Assert.Equal(StatusGame.InvalidMovement, response);

            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(0, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithNotEmptyGameWrongMovementFailed()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);

            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = -1, PositionY = 5 } });
            Assert.Equal(StatusGame.InvalidMovement, response);

            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(1, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithNotEmptyGameWrongMovementUsedFailed()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame =  new PlayerGame() { PositionX = 0, PositionY = 1 } }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);

            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1 } });
            Assert.Equal(StatusGame.InvalidMovement, response);

            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(1, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithNotEmptyGameEndWithLessThanNineMovementsOk()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 0} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);

            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0 } });
            Assert.Equal(StatusGame.GameEnd, response);

            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(4, valueProperty.Count);
        }

        [Fact]
        public void InsertPosition_WithNotEmptyGameEndWithNineMovementsOk()
        {
            List<PlayerGameInfo> gameTable = new List<PlayerGameInfo>()
            {
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 2} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 0} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 2} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 2} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 0} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 1, PositionY = 1} },
                new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer2.Object, playerGame = new PlayerGame() { PositionX = 2, PositionY = 1} }
            };
            TicTacToeGame ticTacToeGame = new TicTacToeGame(_setupCodeUnit.mockPlayer1.Object, _setupCodeUnit.mockPlayer2.Object);
            FieldInfo field = typeof(TicTacToeGame).GetField("gameTable", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(ticTacToeGame, gameTable);

            StatusGame response = ticTacToeGame.InsertPosition(new PlayerGameInfo() { player = _setupCodeUnit.mockPlayer1.Object, playerGame = new PlayerGame() { PositionX = 0, PositionY = 1 } });
            Assert.Equal(StatusGame.GameEnd, response);

            var valueProperty = (List<PlayerGameInfo>)field.GetValue(ticTacToeGame);
            Assert.Equal(9, valueProperty.Count);
        }
    }
}