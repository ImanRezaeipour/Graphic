using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl7_Tamrin3
{
    public partial class FrmMain : Form
    {
        private PointF _pointO;
        private PointF _pointA;
        private int _number;
        private int _radius;

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
            _radius = (int)numRadius.Value;
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
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.DrawEllipse(Pens.Green, pointA.X - _radius, pointA.Y - _radius, _radius * 2, _radius * 2);
            Draw(pointB, number - 1);
        }
    }
}
