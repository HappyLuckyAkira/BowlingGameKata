using NUnit.Framework;
// TODO
//�@�ʏ�̃X�R�A�v�Z���ł��邱��(No mark) ok
// �ЂƂ̃X�y�A�̌v�Z���ł��邱��
// �ЂƂ̃X�g���C�N�̌v�Z���ł��邱��
// �S���X�g���C�N�ŁA300�_�ɂȂ邱��

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
        public void �S�ăK�^�[��������0�_()
        {
            RollMany(20,0);
            Assert.AreEqual(0,_game.Score());
        }
        [Test]
        public void �S1��������20�_()
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