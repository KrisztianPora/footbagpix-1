﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbagPix.Logic
{
    public interface ICharacterLogic
    {
        void MoveLeft();
        void MoveRight();
        void TryHitBall();
        void KickLeft();
        void KickRight();
        void Turn();
    }
}
