﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FootbagPix.Models
{
    class TimerModel
    {
        public int TimeLeft { get; set; }
        public bool GameOver { get; set; }
        public ImageBrush gameOverBrush { get; set; }
        public TimerModel(int timeLeft=60)
        {
            TimeLeft = timeLeft;
            GameOver = false;
            gameOverBrush = new ImageBrush(new BitmapImage(new Uri("Resources/ImageResources/game_over.png", UriKind.Relative)));
            gameOverBrush.Opacity = 0;
        }
    }
}
