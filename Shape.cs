using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab5_2sem
{
    internal abstract class Shape
    {
        bool isMoving = false;
        protected Vector2 position;

        public Shape(Vector2 position)
        {
            this.position = position;
        }

        public abstract void DrawBlack(Graphics g);
        public abstract void HideDrawingBackground(Graphics g);
        public void MoveRight(Graphics g)
        {
            HideDrawingBackground(g);
            if (isMoving)
            {
                position.X += 1;
                if (position.X > 500)
                {
                    position.X = 100;
                }
                DrawBlack(g);
            }
            else position.X = 100;
        }

        public void SwapState()
        {
            isMoving = !isMoving;
        }
     
    }
}
