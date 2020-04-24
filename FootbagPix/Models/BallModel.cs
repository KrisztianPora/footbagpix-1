﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FootbagPix.Models
{
    public class BallModel
    {
        const int width = 20;
        const int heigth = 20;

        public Rect area;
        public Rect Area { get { return area; } }
        public double SpeedX { get; set; }
        public double SpeedY { get; set; }
        public double TimeOnAir { get; set; }
        public ImageBrush imageBrush { get; set; }
            

        public BallModel()
        {
            imageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Resources/ImageResources/ball.png")));

            area = new Rect((Config.windowWidth - BallModel.width)/2, 50, 20, 20);
            SpeedX = 0;
            SpeedY = 0;
            TimeOnAir = 0;
        }
        
    }
}
