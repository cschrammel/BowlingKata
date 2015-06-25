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
    
        [Fact]
        public void AllOnes(){
            var game = new Game();
            for (int i = 0; i < 21; i++)
                game.Roll(1);
            Assert.Equal(21, game.Score());
        }
        
        [Fact]
        public void OneSpare(){
            var game = new Game();
            game.Roll(5);
            game.Roll(5);
            game.Roll(1);
            Assert.Equal(12, game.Score());
        }
    }
} 