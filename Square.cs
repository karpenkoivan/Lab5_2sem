using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2sem
{
    internal class Square : Shape
    {
        double sideLength;
        public override void DrawBlack(Graphics g)
        {
            g.DrawRectangle(Pens.Black, (float)position.X, (float)position.Y, (float)sideLength, (float)sideLength);
        }
        public override void HideDrawingBackground(Graphics g)
        {
            g.DrawRectangle(Pens.White, (float)position.X, (float)position.Y, (float)sideLength, (float)sideLength);
        }
    {
    }
}
