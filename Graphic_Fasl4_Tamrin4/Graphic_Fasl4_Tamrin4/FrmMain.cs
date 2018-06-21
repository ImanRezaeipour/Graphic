using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic_Fasl4_Tamrin4
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
            PointF vectorBA = new PointF((pointA.X - pointB.X), (pointA.Y - pointB.Y));
            PointF vectorCB = new PointF((pointB.X - pointC.X), (pointB.Y - pointC.Y));
            PointF vectorAB = new PointF((pointB.X - pointA.X), (pointB.Y - pointA.Y));
            PointF pointD = new PointF((pointA.X + vectorBA.X), (pointA.Y + vectorBA.Y));
            PointF pointE = new PointF((pointB.X + vectorAB.X), (pointB.Y + vectorAB.Y));
            PointF pointF = new PointF((pointB.X + vectorCB.X), (pointB.Y + vectorCB.Y));
            // NIMSAZE CAB
            float lineAB = (float)Math.Sqrt((Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2)));
            float lineAC = (float)Math.Sqrt((Math.Pow(pointC.X - pointA.X, 2) + Math.Pow(pointC.Y - pointA.Y, 2)));
            PointF uAB = new PointF((pointB.X - pointA.X) / lineAB, (pointB.Y - pointA.Y) / lineAB);//yekan ab
            PointF uAC = new PointF((pointC.X - pointA.X) / lineAC, (pointC.Y - pointA.Y) / lineAC);//yekan ac
            PointF uA = new PointF(uAB.X + uAC.X, uAB.Y + uAC.Y);
            PointF vA = new PointF(-uA.Y, uA.X);
            float r1 = vA.X * pointA.X + vA.Y * pointA.Y;//c1
            float[] M1 = new float[] { vA.X, vA.Y, r1 };//a1x+b1y=c1  
            // NIMSAZE ABC
            float lineBA = (float)Math.Sqrt((Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2)));
            float lineBC = (float)Math.Sqrt((Math.Pow(pointC.X - pointB.X, 2) + Math.Pow(pointC.Y - pointB.Y, 2)));
            PointF uBA = new PointF((pointA.X - pointB.X) / lineBA, (pointA.Y - pointB.Y) / lineBA);//yekan ba
            PointF uBC = new PointF((pointC.X - pointB.X) / lineBC, (pointC.Y - pointB.Y) / lineBC);//yekan bc
            PointF uB = new PointF(uBA.X + uBC.X, uBA.Y + uBC.Y);
            PointF vB = new PointF(-uB.Y, uB.X);
            float r2 = vB.X * pointB.X + vB.Y * pointB.Y;//c2
            float[] M2 = new float[] { vB.X, vB.Y, r2 };//a2x+b2y=c2 
            //
            PointF O = new PointF((M1[2] * M2[1] - M2[2] * M1[1]) / (M1[0] * M2[1] - M2[0] * M1[1]), (M1[0] * M2[2] - M2[0] * M1[2]) / (M1[0] * M2[1] - M2[0] * M1[1]));
            float r = (float)(2 * 0.5 * (pointA.X * pointB.Y - pointA.Y * pointB.X + pointB.X * O.Y - pointB.Y * O.X + O.X * pointA.Y - O.Y * pointA.X) / Math.Sqrt((Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2))));//2*area(a,b,o)/|ab|
            // NIMSAZE DAC
            float lineAD = (float)Math.Sqrt((Math.Pow(pointD.X - pointA.X, 2) + Math.Pow(pointD.Y - pointA.Y, 2)));
            // float lineAC = (float)Math.Sqrt((Math.Pow(pointC.X - pointA.X, 2) + Math.Pow(pointC.Y - pointA.Y, 2)));
            PointF uAD = new PointF((pointD.X - pointA.X) / lineAD, (pointD.Y - pointA.Y) / lineAD);//yekan ad
            // PointF uAC = new PointF((pointC.X - pointA.X) / lineAC, (pointC.Y - pointA.Y) / lineAC);
            PointF uD = new PointF(uAD.X + uAC.X, uAD.Y + uAC.Y);
            PointF vD = new PointF(-uD.Y, uD.X);
            float r3 = vD.X * pointA.X + vD.Y * pointA.Y;//c3
            float[] M3 = new float[] { vD.X, vD.Y, r3 };//a3x+b3y=c3
            //
            PointF OCA = new PointF((M2[2] * M3[1] - M3[2] * M2[1]) / (M2[0] * M3[1] - M3[0] * M2[1]), (M2[0] * M3[2] - M3[0] * M2[2]) / (M2[0] * M3[1] - M3[0] * M2[1]));
            float rca = (float)(2 * 0.5 * (pointA.X * pointC.Y - pointA.Y * pointC.X + pointC.X * OCA.Y - pointC.Y * OCA.X + OCA.X * pointA.Y - OCA.Y * pointA.X) / Math.Sqrt((Math.Pow(pointC.X - pointA.X, 2) + Math.Pow(pointC.Y - pointA.Y, 2))));//2*area(a,c,oca)/|ac|
            // NIMSAZE CBE
            float lineBE = (float)Math.Sqrt((Math.Pow(pointE.X - pointB.X, 2) + Math.Pow(pointE.Y - pointB.Y, 2)));
            // float lineBC = (float)Math.Sqrt((Math.Pow(pointC.X - pointB.X, 2) + Math.Pow(pointC.Y - pointB.Y, 2)));
            PointF uBE = new PointF((pointE.X - pointB.X) / lineBE, (pointE.Y - pointB.Y) / lineBE);//yekan be
            // PointF uBC = new PointF((pointC.X - pointB.X) / lineBC, (pointC.Y - pointB.Y) / lineBC);
            PointF uE = new PointF(uBE.X + uBC.X, uBE.Y + uBC.Y);
            PointF vE = new PointF(-uE.Y, uE.X);
            float r4 = vE.X * pointB.X + vE.Y * pointB.Y;//c4
            float[] M4 = new float[] { vE.X, vE.Y, r4 };//a4x+b4y=c4
            //
            PointF OBC = new PointF((M1[2] * M4[1] - M4[2] * M1[1]) / (M1[0] * M4[1] - M4[0] * M1[1]), (M1[0] * M4[2] - M4[0] * M1[2]) / (M1[0] * M4[1] - M4[0] * M1[1]));
            float rbc = (float)(2 * 0.5 * (pointB.X * pointC.Y - pointB.Y * pointC.X + pointC.X * OBC.Y - pointC.Y * OBC.X + OBC.X * pointB.Y - OBC.Y * pointB.X) / Math.Sqrt((Math.Pow(pointC.X - pointB.X, 2) + Math.Pow(pointC.Y - pointB.Y, 2))));//2*area(b,c,obc)/|bc|
            // NIMSAZE ABF
            float lineBF = (float)Math.Sqrt((Math.Pow(pointF.X - pointB.X, 2) + Math.Pow(pointF.Y - pointB.Y, 2)));
            // float lineBA = (float)Math.Sqrt((Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2)));
            PointF uBF = new PointF((pointF.X - pointB.X) / lineBF, (pointF.Y - pointB.Y) / lineBF);//yekan bf
            // PointF uBA = new PointF((pointA.X - pointB.X) / lineBA , (pointA.Y - pointB.Y) / lineBA);
            PointF uF = new PointF(uBF.X + uBA.X, uBF.Y + uBA.Y);
            PointF vF = new PointF(-uF.Y, uF.X);
            float r5 = vF.X * pointB.X + vF.Y * pointB.Y;//c5
            float[] M5 = new float[] { vF.X, vF.Y, r5 };//a5x+b5y=c5
            // NIMSAZE ACB
            float lineCA = (float)Math.Sqrt((Math.Pow(pointA.X - pointC.X, 2) + Math.Pow(pointA.Y - pointC.Y, 2)));
            float lineCB = (float)Math.Sqrt((Math.Pow(pointB.X - pointC.X, 2) + Math.Pow(pointB.Y - pointC.Y, 2)));
            PointF uCA = new PointF((pointA.X - pointC.X) / lineCA, (pointA.Y - pointC.Y) / lineCA);//yekan ca
            PointF uCB = new PointF((pointB.X - pointC.X) / lineCB, (pointB.Y - pointC.Y) / lineCB);//yekan cb
            PointF uC = new PointF(uCA.X + uCB.X, uCA.Y + uCB.Y);
            PointF vC = new PointF(-uC.Y, uC.X);
            float r6 = vC.X * pointC.X + vC.Y * pointC.Y;//c6
            float[] M6 = new float[] { vC.X, vC.Y, r6 };//a6x+b6y=c6 
            //
            PointF OAB = new PointF((M5[2] * M6[1] - M6[2] * M5[1]) / (M5[0] * M6[1] - M6[0] * M5[1]), (M5[0] * M6[2] - M6[0] * M5[2]) / (M5[0] * M6[1] - M6[0] * M5[1]));
            float rab = (float)(2 * 0.5 * (pointA.X * pointB.Y - pointA.Y * pointB.X + pointB.X * OAB.Y - pointB.Y * OAB.X + OAB.X * pointA.Y - OAB.Y * pointA.X) / Math.Sqrt((Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2))));//2*area(a,b,oab)/|ab|
            // Drawing
            Graphics graphic = pnlPaint.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.DrawPolygon(Pens.Green, new PointF[] { pointA, pointB, pointC });
            graphic.FillEllipse(Brushes.Green, O.X - r, O.Y - r, 2 * r, 2 * r);
            graphic.FillEllipse(Brushes.Green, OCA.X - rca, OCA.Y - rca, 2 * rca, 2 * rca);
            graphic.FillEllipse(Brushes.Green, OBC.X - rbc, OBC.Y - rbc, 2 * rbc, 2 * rbc);
            graphic.FillEllipse(Brushes.Green, OAB.X - rab, OAB.Y - rab, 2 * rab, 2 * rab);
        }
    }
}
