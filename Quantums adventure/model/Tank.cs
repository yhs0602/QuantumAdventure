﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantums_adventure.model
{
    public class Tank : MovingGameObject

    {

        private readonly double _speed;



        protected override double SpeedFactor => _speed * base.SpeedFactor;



        public Tank(GameField field, CellLocation location, Facing facing, double speed) : base(field, location, facing)

        {

            _speed = speed;

        }

    }
}
