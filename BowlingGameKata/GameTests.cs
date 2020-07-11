using NUnit.Framework;
// TODO
//　通常のスコア計算ができること(No mark)
// ひとつのスペアの計算ができること
// ひとつのストライクの計算ができること
// 全部ストライクで、300点になること

namespace BowlingGameKata
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void 全てガターだったら0点()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0,game.Score());
        }
        [Test]
        public void 全1だったら20点()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }
            Assert.AreEqual(20,game.Score());
        }
    }
}