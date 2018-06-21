using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl4_Tamrin1
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
            Refresh();
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
            PointF pointF = new PointF(pointC.X + vectorW.X, pointC.Y + vectorW.Y);
            PointF pointE = new PointF((pointD.X + pointF.X) / 2, (pointD.Y + pointF.Y) / 2);
            double lineAB = Math.Sqrt(Math.Pow(vectorAB.X, 2) + Math.Pow(vectorAB.Y, 2));
            if (lineAB < 5) return;
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.DrawPolygon(Pens.Green, new[] { pointA, pointB, pointC, pointD });
            graphic.FillPolygon(Brushes.Green, new[] { pointC, pointD, pointE });
            Draw(pointD, pointE);
            Draw(pointE, pointC);
        }
    }
}
