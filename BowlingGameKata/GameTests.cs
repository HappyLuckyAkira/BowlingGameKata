using NUnit.Framework;
// TODO
//�@�ʏ�̃X�R�A�v�Z���ł��邱��(No mark)
// �ЂƂ̃X�y�A�̌v�Z���ł��邱��
// �ЂƂ̃X�g���C�N�̌v�Z���ł��邱��
// �S���X�g���C�N�ŁA300�_�ɂȂ邱��

namespace BowlingGameKata
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void �S�ăK�^�[��������0�_()
        {
            var game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.AreEqual(0,game.Score());
        }
        [Test]
        public void �S1��������20�_()
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