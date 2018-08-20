using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.Interfaces;
using Moq;

namespace Chess.Tests
{
    [TestClass]
    public class MoveProviderTests
    {
        [TestMethod]
        public void GetMoveTest()
        {
            var mockIP = new Mock<IInputProvider>();

            mockIP.Setup(x => x.Read())
                  .Returns("3");

            var moveProvider = new MoveProvider(mockIP.Object);

            var expected = new Move();
            expected.Source = new Position(3, 3);
            expected.Dest = new Position(3, 3);

            var actual = moveProvider.GetMove();
            Assert.AreEqual(expected.Source.Row, actual.Source.Row);
            Assert.AreEqual(expected.Source.Column, actual.Source.Column);
            Assert.AreEqual(expected.Dest.Row, actual.Dest.Row);
            Assert.AreEqual(expected.Dest.Column, expected.Dest.Column);
        }
    }
}
