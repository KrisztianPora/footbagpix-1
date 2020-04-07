﻿using FootbagPix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbagPix.Logic
{
    class ScoreLogic
    {
        ScoreModel score;
        BallModel ball;
        public event EventHandler RefreshScreen;
        int groundPosition = 415;

        public ScoreLogic(ScoreModel score, BallModel ball)
        {
            this.score = score;
            this.ball = ball;
        }

        public const int scorePerKick = 10; // later put into config.cs ?

        public void Increase()
        {
            score.ComboCounter++;
            score.CurrentScore = score.CurrentScore + (scorePerKick * score.ComboCounter);
        }

        public void CheckIfBallFell()
        {
            if (ball.area.Y >= groundPosition)
            {
                score.ComboCounter = 0;
            }
            RefreshScreen?.Invoke(this, EventArgs.Empty);
        }

        public void Reset()
        {
            score.CurrentScore = 0;
        }

    }
}
