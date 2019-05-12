﻿using System;
using TreehouseDefense;

namespace TreeHouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        protected virtual int StepSize { get; } = 1;
        public MapLocation Location => _path.GetLoactionAt(_pathStep);

        public virtual int Health { get; protected set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit the invader!");
        }
    }
}
