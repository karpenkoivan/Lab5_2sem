using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab5_2sem
{
    internal class Rhomb : Shape
    {
       
        PointF[] points = new PointF[4];

        public Rhomb(float diagonal1, float diagonal2, Vector2 position) : base(position)
        {
            if (diagonal1 <= 0 || diagonal2 <= 0) throw new ArgumentException("Diagonals must be greater than zero.");
            
            points[0] = new PointF(0, - diagonal2 / 2);
            points[1] = new PointF(diagonal1 / 2, 0);
            points[2] = new PointF(0, diagonal2 / 2);
            points[3] = new PointF(-diagonal1 / 2, 0);
        }


        public override void DrawBlack(Graphics g)
        {
            g.DrawPolygon(Pens.Black, points.Select(p => new PointF(p.X + position.X, p.Y + position.Y)).ToArray());
        }

        public override void HideDrawingBackground(Graphics g)
        {
            g.DrawPolygon(Pens.White, points.Select(p => new PointF(p.X + position.X, p.Y + position.Y)).ToArray());
        }
    }
}
