using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab5_2sem
{
    internal class Circle : Shape
    {
        double radius;

        public Circle(double radius, Vector2 position) : base(position)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be greater than zero.");
            this.radius = radius;
        }

        public override void DrawBlack(Graphics g)
        {
            g.DrawEllipse(Pens.Black, (float)position.X, (float)position.Y, (float)radius * 2, (float)radius * 2);
        }

        public override void HideDrawingBackground(Graphics g)
        {
            g.DrawEllipse(Pens.White, (float)position.X, (float)position.Y, (float)radius * 2, (float)radius * 2);

        }
    }
}
