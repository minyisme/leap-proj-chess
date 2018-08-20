using System;
using Chess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Chess.Tests
{
    [TestClass]
    public class HumanPlayerTests
    {
        [TestMethod]
        public void CreateNewHumanPlayer()
        {
            var name = "Unit Test Player";
            var boardSide = BoardSide.Bottom;
            var playerColor = PlayerColor.Black;
            var testPlayer = new HumanPlayer(name, boardSide, playerColor);
            Assert.AreEqual(name, testPlayer.Name);
            Assert.AreEqual(PlayerColor.Black, testPlayer.Color);
            Assert.AreEqual(BoardSide.Bottom, testPlayer.Side);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateInvalidPlayer()
        {
            var name = "";
            var boardSide = BoardSide.Bottom;
            var playerColor = PlayerColor.Black;
            var testPlayer = new HumanPlayer(name, boardSide, playerColor);
            Assert.AreEqual(name, testPlayer.Name);
            Assert.AreEqual(PlayerColor.Black, testPlayer.Color);
            Assert.AreEqual(BoardSide.Bottom, testPlayer.Side);
        }

        [TestMethod]
        public void GetPlayerMove()
        {
            var name = "FakePlayer";
            var boardSide = BoardSide.Bottom;
            var playerColor = PlayerColor.Black;
            var mockMoveProvider = new Mock<IMoveProvider>();
            var testPlayer = new HumanPlayer(name, boardSide, playerColor, mockMoveProvider.Object);
            var mockMove = new Move();
            mockMove.Source = new Position(3,3);
            mockMove.Dest = new Position(4, 4);

            mockMoveProvider
            .Setup(x => x.GetMove())
            .Returns(mockMove);
            var move = testPlayer.GetMove();
            Assert.AreEqual(mockMove.Source, move.Source);
            Assert.AreEqual(mockMove.Dest, move.Dest);
        }
    }
}
