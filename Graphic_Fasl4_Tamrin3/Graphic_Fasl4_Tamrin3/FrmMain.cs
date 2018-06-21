using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl4_Tamrin3
{
    public partial class FrmMain : Form
    {
        private PointF _pointA;
        private PointF _pointB;
        private PointF _pointC;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDrawClick(object sender, EventArgs e)
        {
            Refresh();
            _pointA = new PointF(Convert.ToInt32(numPointAX.Text), Convert.ToInt32(numPointAY.Text));
            _pointB = new PointF(Convert.ToInt32(numPointBX.Text), Convert.ToInt32(numPointBY.Text));
            _pointC = new PointF(Convert.ToInt32(numPointCX.Text), Convert.ToInt32(numPointCY.Text));
            Draw(_pointA, _pointB, _pointC);
        }

        private void Draw(PointF pointA, PointF pointB, PointF pointC)
        {
            PointF vectorAB = new PointF(pointB.X - pointA.X, pointB.Y - pointA.Y);
            PointF middleAB = new PointF((pointA.X + pointB.X) / 2, (pointA.Y + pointB.Y) / 2);
            float r1 = (vectorAB.X * middleAB.X + vectorAB.Y * middleAB.Y);//c1
            //
            PointF vectorBC = new PointF(pointC.X - pointB.X, pointC.Y - pointB.Y);
            PointF middleBC = new PointF((pointB.X + pointC.X) / 2, (pointB.Y + pointC.Y) / 2);
            float r2 = (vectorBC.X * middleBC.X + vectorBC.Y * middleBC.Y);//c2
            // r1    r2                     r1      r2
            // ab.y  bc.y                   ab.x    bc.x 
            // ab.x  bc.x                   ab.y    bc.y
            PointF pointO = new PointF((r1 * vectorBC.Y - r2 * vectorAB.Y) / (vectorAB.X * vectorBC.Y - vectorBC.X * vectorAB.Y), (vectorAB.X * r2 - vectorBC.X * r1) / (vectorAB.X * vectorBC.Y - vectorBC.X * vectorAB.Y));
            // radius OA
            float radius = (float)Math.Sqrt((Math.Pow(pointA.X - pointO.X, 2) + Math.Pow(pointA.Y - pointO.Y, 2)));
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.FillPolygon(Brushes.Green, new PointF[] { pointA, pointB, pointC });
            graphic.DrawEllipse(Pens.Green, pointO.X - radius, pointO.Y - radius, 2 * radius, 2 * radius);
        }
    }
}
