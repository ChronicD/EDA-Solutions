using System;

namespace Phase0_Exercise30_Simple_Guessing_Game
{
    public class GuessingGame
    {
        int correctAnswer;
        bool check = false;

        public GuessingGame(int answer)
        {
            correctAnswer = answer;
        }

        public string guess(int guess)
        {
            string result;
            if (guess > correctanswer)
            {
                result = "high";
            }
            else if (guess < correctanswer)
            {
                result = "low";
            }
            else
            {
                check = true;
                result = "correct";
            }
            return result;
        }

        public bool IsSolved()
        {
            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}