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
    public class CharacterModel
    {
        // to be implemented
        public Rect leftFoot, rigthFoot, body;
        public Point head;
        public Rect LeftFoot { get { return leftFoot; } }
        public Rect RigthFoot { get { return rigthFoot; } }
        public Rect Body { get { return body; } }
        public Point Head { get { return head; } }
        public int PositionX { get; set; }

        public int SpriteWidth { get; set; }
        public int SpriteHeight{ get; set; }

        public ImageBrush imageBrush { get; set; }

        public CharacterModel()
        {
            SpriteWidth = 95;
            SpriteHeight = 214;

            imageBrush = new ImageBrush(new BitmapImage(new Uri("Resources/ImageResources/character_sprite3.png", UriKind.Relative)));
            
            imageBrush.Viewbox = new Rect(0,0, SpriteWidth, SpriteHeight);
            imageBrush.ViewboxUnits = BrushMappingMode.Absolute;
            imageBrush.Stretch = Stretch.None;

            leftFoot = new Rect(310, 300, 40, 20);
            rigthFoot = new Rect(360, 300, 40, 20);
            
            PositionX = 310;
        }
    }
}
