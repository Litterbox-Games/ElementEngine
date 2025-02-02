﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElementEngine
{
    public class GameTimer
    {
        protected TimeSpan _frameTime;
        public TimeSpan FrameTime { get => _frameTime; }
        public float TimeWarpFactor = 1f;

        public float DeltaS { get => (float)FrameTime.TotalSeconds; }
        public float DeltaMS { get => (float)FrameTime.TotalMilliseconds; }

        public GameTimer()
        {
            _frameTime = TimeSpan.Zero;
        }

        public void SetFrameTime(TimeSpan frameTime)
        {
            _frameTime = frameTime * TimeWarpFactor;
        }
    }
}
