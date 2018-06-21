using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl7_Tamrin4
{
    public partial class FrmMain : Form
    {
        private PointF _pointO;
        private PointF _pointA;
        private int _number;

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
            Draw(_pointA, _number);
        }

        private void Draw(PointF pointA, int number)
        {
            if (number == 0) return;
            float t = (float)(2 * Math.PI / _number);
            // Davaran
            float sinT = (float)Math.Sin(t);
            float cosT = (float)Math.Cos(t);
            PointF pointA1 = new PointF(pointA.X - _pointO.X, pointA.Y - _pointO.Y);
            PointF pointA2 = new PointF(pointA1.X * cosT - pointA1.Y * sinT, pointA1.X * sinT + pointA1.Y * cosT);
            PointF pointB = new PointF(pointA2.X + _pointO.X, pointA2.Y + _pointO.Y);
            PointF m = new PointF((float)((pointA.X + pointB.X) / 2), (float)((pointA.Y + pointB.Y) / 2));
            // Yekan
            float lineAB = (float)Math.Sqrt((pointB.X - pointA.X) * (pointB.X - pointA.X) + (pointB.Y - pointA.Y) * (pointB.Y - pointA.Y));
            PointF u = new PointF((_pointO.X - m.X) / lineAB, (_pointO.Y - m.Y) / lineAB);
            float lineAO = 1 / 4 * ((float)Math.Sqrt((_pointO.X - pointA.X) * (_pointO.X - pointA.X) + (_pointO.Y - pointA.Y) * (_pointO.Y - pointA.Y)));
            u = new PointF(u.X * lineAO, u.Y * lineAO);
            PointF e = new PointF(m.X + u.X, m.Y + u.Y);
            PointF mc2 = new PointF(_pointO.X - e.X, _pointO.Y - e.Y);
            float n = (float)(Math.Sqrt(mc2.X * mc2.X + mc2.Y * mc2.Y));
            if (n <= 10) return;
            PointF[] arrP = { pointA, e, pointB, _pointO };
            PointF[] arrPLine = { pointA, e, pointB };
            PointF[] arrP2 = { pointA, pointB, e };
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.FillPolygon(Brushes.Green, arrP);
            graphic.FillPolygon(Brushes.Green, arrP2);
            graphic.DrawLine(Pens.Black, pointA, pointB);
            graphic.DrawLines(Pens.Black, arrPLine);
            //
            pointA = new PointF(e.X, e.Y);
            Draw(pointB, number - 1);
            if (number != 1) return;
            number = _number;
            Draw(pointA, number);
        }
    }
}
