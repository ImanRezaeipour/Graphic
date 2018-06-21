using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl7_Tamrin2
{
    public partial class FrmMain : Form
    {
        private PointF _pointO;
        private PointF _pointA;
        private int _number;
        private int _depth;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDrawClick(object sender, EventArgs e)
        {
            Refresh();
            _pointO = new PointF(Convert.ToInt32(numPointOX.Text), Convert.ToInt32(numPointOY.Text));
            _pointA = new PointF(Convert.ToInt32(numPointAX.Text), Convert.ToInt32(numPointAY.Text));
            _number = (int)numNumber.Value;
            _depth = (int)numDepth.Value;
            Draw(_pointA, _number);
        }

        private void Draw(PointF pointA, int number)
        {
            if (number == 0) return;
            float t = (float)(2 * Math.PI / _number);
            // Davaran
            float sinT = (float)Math.Sin(t);
            float cosT = (float)Math.Cos(t);
            //vector OA
            PointF pointA1 = new PointF(pointA.X - _pointO.X, pointA.Y - _pointO.Y);
            //davaran A1...
            PointF pointA2 = new PointF(pointA1.X * cosT - pointA1.Y * sinT, pointA1.X * sinT + pointA1.Y * cosT);
            //vector OA2
            PointF pointB = new PointF(pointA2.X + _pointO.X, pointA2.Y + _pointO.Y);
            PointF middle = new PointF((float)((pointA.X + pointB.X) / 2), (float)((pointA.Y + pointB.Y) / 2));
            // Yekan
            float lineAB = (float)Math.Sqrt((pointB.X - pointA.X) * (pointB.X - pointA.X) + (pointB.Y - pointA.Y) * (pointB.Y - pointA.Y));
            //nimsaz  middle O / |AB|
            PointF u = new PointF((_pointO.X - middle.X) / lineAB, (_pointO.Y - middle.Y) / lineAB);
            u = new PointF(u.X * _depth, u.Y * _depth);
            //vector e
            PointF e = new PointF(middle.X + u.X, middle.Y + u.Y);
            PointF[] arrP = { pointA, e, pointB, _pointO };
            PointF[] arrPLine = { pointA, e, pointB };
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.FillPolygon(Brushes.Green, arrP);
            graphic.DrawLines(Pens.Green, arrPLine);
            Draw(pointB, number - 1);
        }
    }
}
