using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2sem
{
    internal class Rhomb : Shape
    {
        float diagonal1;
        float diagonal2;
        PointF[] points = new PointF[4];

        public Rhomb(float diagonal1, float diagonal2)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            points[0] = new PointF(position.X, position.Y - diagonal2 / 2);
            points[1] = new PointF(position.X + diagonal1 / 2, position.Y);
            points[2] = new PointF(position.X, position.Y + diagonal2 / 2);
            points[3] = new PointF(position.X - diagonal1 / 2, position.Y);
        }


        public override void DrawBlack(Graphics g)
        {
            g.DrawPolygon(Pens.Black, points);
        }

        public override void HideDrawingBackground(Graphics g)
        {
            g.DrawPolygon(Pens.White, points);
        }
    }
}
