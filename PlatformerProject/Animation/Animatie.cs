﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformerProject.Animation
{
    internal class Animatie
    {
        public AnimationFrame CurrentFrame { get; set; }

        private List<AnimationFrame> frames;
        
        private int counter;

        public Animatie()
        {
            frames = new List<AnimationFrame>();
        }
        public void AddFrame(AnimationFrame animationFrame)
        {
            frames.Add(animationFrame);
            CurrentFrame = frames[0];
        }
        private double secondCounter = 0;
        public void Update(GameTime gameTime)
        {
            CurrentFrame = frames[counter];
            secondCounter += gameTime.ElapsedGameTime.TotalSeconds;
            int fps = 16;

            if (secondCounter >= 1d / fps)
            {
                counter++;
                secondCounter = 0;
            }

            if (counter >= frames.Count)
            {
                counter = 0;
            }
        }
    }
}
