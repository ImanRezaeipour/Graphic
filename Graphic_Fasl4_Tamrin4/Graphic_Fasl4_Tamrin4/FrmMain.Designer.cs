namespace Graphic_Fasl4_Tamrin4
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.numPointBY = new System.Windows.Forms.NumericUpDown();
            this.numPointAY = new System.Windows.Forms.NumericUpDown();
            this.numPointBX = new System.Windows.Forms.NumericUpDown();
            this.numPointAX = new System.Windows.Forms.NumericUpDown();
            this.numPointCX = new System.Windows.Forms.NumericUpDown();
            this.numPointCY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointCX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointCY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 5);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(93, 66);
            this.btnDraw.TabIndex = 18;
            this.btnDraw.Text = "رسم شکل";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDrawClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 60);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 58);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(743, 58);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "نقطه C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 36);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 32);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 32);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "نقطه B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "نقطه A:";
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.Color.White;
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaint.Location = new System.Drawing.Point(0, 78);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(790, 490);
            this.pnlPaint.TabIndex = 17;
            // 
            // numPointBY
            // 
            this.numPointBY.Location = new System.Drawing.Point(601, 30);
            this.numPointBY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointBY.Name = "numPointBY";
            this.numPointBY.Size = new System.Drawing.Size(42, 20);
            this.numPointBY.TabIndex = 79;
            this.numPointBY.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // numPointAY
            // 
            this.numPointAY.Location = new System.Drawing.Point(601, 3);
            this.numPointAY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointAY.Name = "numPointAY";
            this.numPointAY.Size = new System.Drawing.Size(42, 20);
            this.numPointAY.TabIndex = 78;
            this.numPointAY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numPointBX
            // 
            this.numPointBX.Location = new System.Drawing.Point(672, 30);
            this.numPointBX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointBX.Name = "numPointBX";
            this.numPointBX.Size = new System.Drawing.Size(42, 20);
            this.numPointBX.TabIndex = 77;
            this.numPointBX.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // numPointAX
            // 
            this.numPointAX.Location = new System.Drawing.Point(672, 5);
            this.numPointAX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointAX.Name = "numPointAX";
            this.numPointAX.Size = new System.Drawing.Size(42, 20);
            this.numPointAX.TabIndex = 76;
            this.numPointAX.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numPointCX
            // 
            this.numPointCX.Location = new System.Drawing.Point(672, 56);
            this.numPointCX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointCX.Name = "numPointCX";
            this.numPointCX.Size = new System.Drawing.Size(42, 20);
            this.numPointCX.TabIndex = 80;
            this.numPointCX.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numPointCY
            // 
            this.numPointCY.Location = new System.Drawing.Point(601, 56);
            this.numPointCY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointCY.Name = "numPointCY";
            this.numPointCY.Size = new System.Drawing.Size(42, 20);
            this.numPointCY.TabIndex = 81;
            this.numPointCY.Value = new decimal(new int[] {
            300,
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
            this.Controls.Add(this.numPointCY);
            this.Controls.Add(this.numPointCX);
            this.Controls.Add(this.numPointBY);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.numPointBX);
            this.Controls.Add(this.numPointAY);
            this.Controls.Add(this.numPointAX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دایره محاطی";
            ((System.ComponentModel.ISupportInitialize)(this.numPointBY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointCX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointCY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.NumericUpDown numPointBY;
        private System.Windows.Forms.NumericUpDown numPointAY;
        private System.Windows.Forms.NumericUpDown numPointBX;
        private System.Windows.Forms.NumericUpDown numPointAX;
        private System.Windows.Forms.NumericUpDown numPointCX;
        private System.Windows.Forms.NumericUpDown numPointCY;
    }
}

