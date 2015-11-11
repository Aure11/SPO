using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace KoursWorkBeta
{
    class Datchik
    {
        Rectangle box;
        Rectangle Stolb;
        Point centr;
        Point[] arrp;
        Color boxColor;
        Font f;
        Random rnd;
        int DatTemp;
        public Datchik()
        {
            rnd = new Random();
            arrp = new Point[3];
            arrp[0].X = 20;
            arrp[0].Y = 10;
            arrp[1].X = 20;
            arrp[1].Y = 200;
            arrp[2].X = 150;
            arrp[2].Y = 200;
            box = new Rectangle(50, 100, 80, 20);
            centr = new Point(0, 0);
            DatTemp = rnd.Next(0,30);
            f = new Font("Arial", 13, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        }
        public void SetTemp(int t)
        { DatTemp = t; }

        public int GetTemp()
        { return DatTemp; }

        public Rectangle GetRect()
        { return box; }

        public Color GetColor()
        { return boxColor; }

        public void SetColor(Color c)
        { boxColor = c; }

        public void SetLocation(int X, int Y)
        { box.X = X; box.Y = Y; }

        public Point GetLocation()
        { return box.Location; }

        public void DrawBox(Graphics g)
        {
            SolidBrush sb = new SolidBrush(boxColor);
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawLine(myPen, 20 , box.Y+5, box.X, 105);
            g.DrawLine(myPen, 20 , box.Y+15, box.X, 115);
            g.FillRectangle(new SolidBrush(Color.Green), box);
            g.DrawRectangle(myPen, box);
            myPen.Width = 15;
            g.DrawLines(myPen, arrp);
            g.DrawString((" t = " + (DatTemp.ToString())+"*C"), f, new SolidBrush(Color.Red), box);
            
        }
        public void MoveBox(int dX, int dY)
        {

            box.X += dX;
            box.Y += dY;
            centr.Offset(dX, dY);
        }


    }
}
