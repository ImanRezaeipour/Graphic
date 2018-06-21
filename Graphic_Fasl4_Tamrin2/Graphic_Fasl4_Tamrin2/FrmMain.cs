using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl4_Tamrin2
{
    public partial class FrmMain : Form
    {
        private PointF _pointA;
        private PointF _pointB;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDrawClick(object sender, EventArgs e)
        {
            _pointA = new PointF(Convert.ToInt32(numPointAX.Text), Convert.ToInt32(numPointAY.Text));
            _pointB = new PointF(Convert.ToInt32(numPointBX.Text), Convert.ToInt32(numPointBY.Text));
            Draw(_pointA, _pointB);
        }

        private void Draw(PointF pointA, PointF pointB)
        {
            PointF vectorAB = new PointF(pointB.X - pointA.X, pointB.Y - pointA.Y);
            PointF vectorW = new PointF(vectorAB.Y, -vectorAB.X);
            PointF pointC = new PointF(pointB.X + vectorW.X, pointB.Y + vectorW.Y);
            PointF pointD = new PointF(pointA.X + vectorW.X, pointA.Y + vectorW.Y);
            double lineAB = Math.Sqrt(Math.Pow(vectorAB.X, 2) + Math.Pow(vectorAB.Y, 2));
            if (lineAB < 30) return;
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.DrawPolygon(Pens.Green, new PointF[] { pointA, pointB, pointC, pointD });
            PointF pointE = new PointF(((19 * pointA.X) / 20) + (pointB.X / 20), ((19 * pointA.Y) / 20) + (pointB.Y / 20));
            PointF pointF = new PointF(((19 * pointB.X) / 20) + (pointC.X / 20), ((19 * pointB.Y) / 20) + (pointC.Y / 20));
            Draw(pointE, pointF);
        }
    }
}
