using Scratch.Classes;
using System;
using Xunit;

namespace Scratch.Tests
{
    public class TestRemoteButton
    {
        [Fact]
        public void TestSingleMove()
        {
            var remote = new TVRemote();
           // Assert.Equal(3, remote.MoveASingleLetter(1, 1, "g"));
          //  Assert.Equal(4, remote.MoveASingleLetter(1, 1, "h"));
           // Assert.Equal(3, remote.MoveASingleLetter(2, 1, "f"));
           // Assert.Equal(3, remote.MoveASingleLetter(2, 2, "a"));
        }

        [Fact]
        public void TestWord()
        {
            var remote = new TVRemote();
            Assert.Equal(6, remote.FindNumberOfMovesForWord("bac"));
        }

       
    }
}
