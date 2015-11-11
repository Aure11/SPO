using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KoursWorkBeta
{
    class PowerElement
    {
        Rectangle box;
        Color ElementColor;
        public PowerElement()
        {
            box = new Rectangle(125, 250, 200, 20);
            ElementColor = Color.DarkSlateGray;
        }
        public Rectangle GetRect()
        { return box; }
        public Color GetColor()
        { return ElementColor; }
        public void SetColor(Color c)
        { ElementColor = c; }
        public void SetLocation(int X, int Y)
        { box.X = X; box.Y = Y; }
        public Point GetLocation()
        { return box.Location; }
        public void DrawBox(Graphics g)
        {
            Brush sb = new SolidBrush(ElementColor);
            Pen mypen = new Pen(Color.Brown, 10);
            g.FillRectangle(sb, box);
            
        }
    }
}
