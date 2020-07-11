namespace BowlingGameKata
{
    public class Game
    {
        private int[]  _rolls = new int[21];
        private int _currentRoll;
        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;

        }

        public int Score()
        {
            int score = 0;
            int roll = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(roll)) //Spare
                {
                    score += 10 + _rolls[roll + 2];
                    roll += 2;
                }
                else
                {
                    score += _rolls[roll];
                    score += _rolls[roll + 1];
                    roll += 2;
                }
                
            }

            return score;
        }

        private bool IsSpare(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1] == 10;
        }
    }
}