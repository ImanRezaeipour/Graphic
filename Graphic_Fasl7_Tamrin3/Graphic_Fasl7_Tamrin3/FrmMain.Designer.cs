namespace Graphic_Fasl7_Tamrin3
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.numPointOX = new System.Windows.Forms.NumericUpDown();
            this.numPointAX = new System.Windows.Forms.NumericUpDown();
            this.numPointOY = new System.Windows.Forms.NumericUpDown();
            this.numPointAY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointOY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAY)).BeginInit();
            this.SuspendLayout();
            // 
            // numRadius
            // 
            this.numRadius.Location = new System.Drawing.Point(498, 33);
            this.numRadius.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(42, 20);
            this.numRadius.TabIndex = 69;
            this.numRadius.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(498, 9);
            this.numNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(42, 20);
            this.numNumber.TabIndex = 68;
            this.numNumber.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 35);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "شعاع:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 12);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "تعداد:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 7);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(93, 65);
            this.btnDraw.TabIndex = 55;
            this.btnDraw.Text = "رسم شکل";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDrawClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 38);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 38);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 38);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "گوشه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "مرکز:";
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.Color.White;
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaint.Location = new System.Drawing.Point(0, 78);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(790, 490);
            this.pnlPaint.TabIndex = 70;
            // 
            // numPointOX
            // 
            this.numPointOX.Location = new System.Drawing.Point(675, 8);
            this.numPointOX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointOX.Name = "numPointOX";
            this.numPointOX.Size = new System.Drawing.Size(42, 20);
            this.numPointOX.TabIndex = 71;
            this.numPointOX.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // numPointAX
            // 
            this.numPointAX.Location = new System.Drawing.Point(675, 33);
            this.numPointAX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointAX.Name = "numPointAX";
            this.numPointAX.Size = new System.Drawing.Size(42, 20);
            this.numPointAX.TabIndex = 72;
            this.numPointAX.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // numPointOY
            // 
            this.numPointOY.Location = new System.Drawing.Point(604, 7);
            this.numPointOY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointOY.Name = "numPointOY";
            this.numPointOY.Size = new System.Drawing.Size(42, 20);
            this.numPointOY.TabIndex = 73;
            this.numPointOY.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            // 
            // numPointAY
            // 
            this.numPointAY.Location = new System.Drawing.Point(604, 33);
            this.numPointAY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointAY.Name = "numPointAY";
            this.numPointAY.Size = new System.Drawing.Size(42, 20);
            this.numPointAY.TabIndex = 74;
            this.numPointAY.Value = new decimal(new int[] {
            330,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.numPointAY);
            this.Controls.Add(this.numPointOY);
            this.Controls.Add(this.numPointAX);
            this.Controls.Add(this.numPointOX);
            this.Controls.Add(this.pnlPaint);
            this.Controls.Add(this.numRadius);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "توده ای از دایره ها";
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointOY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.NumericUpDown numPointOX;
        private System.Windows.Forms.NumericUpDown numPointAX;
        private System.Windows.Forms.NumericUpDown numPointOY;
        private System.Windows.Forms.NumericUpDown numPointAY;
    }
}

