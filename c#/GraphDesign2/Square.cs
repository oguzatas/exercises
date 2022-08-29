using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GraphDesign2
{
    public class Square
    {
        public int x { get; set; }

        public void draw(Graphics drawer)
        {
            drawer.DrawRectangle(Pens.Blue,20,20,20,20);
        }
    }
}
