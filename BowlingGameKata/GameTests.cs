using NUnit.Framework;
// TODO
//　通常のスコア計算ができること(No mark) ok
// ひとつのスペアの計算ができること
// ひとつのストライクの計算ができること
// 全部ストライクで、300点になること

namespace BowlingGameKata
{
    public class GameTests
    {
        private  Game _game;
        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void 全てガターだったら0点()
        {
            RollMany(20,0);
            Assert.AreEqual(0,_game.Score());
        }
        [Test]
        public void 全1だったら20点()
        {
            RollMany(20,1);
            Assert.AreEqual(20,_game.Score());
        }
        private void RollMany(int rolls,int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _game.Roll(pins);
            }
        }
    }
}