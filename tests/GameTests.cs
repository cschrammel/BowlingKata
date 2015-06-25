using Xunit;

namespace BowlingKata.Tests
{
    public class GameTests
    {
        [Fact]
        public void GutterGame(){
            var game = new Game();
            Assert.Equal(0, game.Score());
        }
    }
}