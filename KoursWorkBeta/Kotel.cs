using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace KoursWorkBeta
{
    class Kotel
    {
    
        int tWater;
        int Hight;
        Rectangle WaterLevel;
        Rectangle box;
        Rectangle KrishkaKotla;
        Point centr;
        Color boxColor;
        public Kotel()
        {
            
            box = new Rectangle(150, 50, 150, 200);
            KrishkaKotla = new Rectangle(150, 50, 150, 50);
            centr = new Point(0, 0);
            WaterLevel = new Rectangle();
            Hight = 0;
          
        }
        
        public void SetTempr(int t)
        {
            tWater = t;
        }

        public int GetMass()
        {
            return Hight;
        }

        public void SetHightWater(int h)
        {
            Hight = h;
 
        }
        public Rectangle GetRect()
        { return box; }

        public void SetRect(Rectangle r)
        {
            box = r;
        } 
        public Color GetColor()
        { return boxColor; }

        public void SetColor(Color c)
        { boxColor = c; }

        public void SetLocation(int X,int Y)
        { box.X = X; box.Y = Y; }

        public Point GetLocation()
        { return box.Location; }

        public void DrawKotel(Graphics g)
        {
            SolidBrush sb = new SolidBrush(boxColor);
            Pen myPen = new Pen(Color.Gray, 10);
            g.DrawLine(myPen, 0, 150, box.X,150);
            g.DrawLine(myPen, 0, 160, box.X, 160);
            g.FillRectangle(new SolidBrush(Color.LightBlue), box);
            g.FillRectangle(new SolidBrush(Color.DarkGray), box.X, box.Y, box.Width, box.Height - Hight);
            g.FillRectangle(new SolidBrush(Color.DarkRed), KrishkaKotla);
            g.DrawRectangle(myPen, box);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black),15), KrishkaKotla);
            myPen.Dispose();
            }
        public void MoveBox(int dX, int dY)
        { 
            box.X += dX;
            box.Y += dY;
            KrishkaKotla.X += dX;
            KrishkaKotla.Y += dY;
            centr.Offset(dX, dY);
        }
             
    }
   
}
