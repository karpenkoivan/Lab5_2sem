using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab5_2sem
{
    internal abstract class Shape
    {
        protected Vector2 position;
        public abstract void DrawBlack(Graphics g);
        public abstract void HideDrawingBackground(Graphics g);
        public void MoveRight(Graphics g)
        {
            HideDrawingBackground(g);
            position.X += 1;
            if(position.X > 800)
            {
                position.X = 0;
            }
            DrawBlack(g);
        }
    }
}
