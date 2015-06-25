using Xunit;

namespace BowlingKata.Tests
{
    public class GameTests
    {
        [Fact]
        public void Gutterball()
        {
            var game = new Game();
            game.Roll(0);
            Assert.Equal(0, game.Score());
        }
        
        [Fact]
        public void OnePinRoll()
        {
            var game = new Game();
            game.Roll(1);
            Assert.Equal(1, game.Score());
        }
        
        [Fact]
        public void Spare() {
            var game = new Game();
            game.Roll(5);
            game.Roll(5); 
            game.Roll(1);
            Assert.Equal(12, game.Score());
        }
        
        [Fact]
        public void Strike() {
            var game = new Game();
            game.Roll(10);
            game.Roll(5); 
            game.Roll(1);
            Assert.Equal(22, game.Score());
        }
        
        [Fact]
        public void latterStrike() {
            var game = new Game();
            game.Roll(3);
            game.Roll(6);
            game.Roll(10);
            game.Roll(5); 
            game.Roll(1);
            Assert.Equal(31, game.Score());
        }
        
    } 
} 