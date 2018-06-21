namespace Graphic_Fasl4_Tamrin1
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
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPointAX = new System.Windows.Forms.NumericUpDown();
            this.numPointBX = new System.Windows.Forms.NumericUpDown();
            this.numPointAY = new System.Windows.Forms.NumericUpDown();
            this.numPointBY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 6);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 66);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "رسم شکل";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDrawClick);
            // 
            // pnlPaint
            // 
            this.pnlPaint.BackColor = System.Drawing.Color.White;
            this.pnlPaint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaint.Location = new System.Drawing.Point(0, 78);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(790, 490);
            this.pnlPaint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نقطه A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 37);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "نقطه B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 8);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 11);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 37);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 37);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X:";
            // 
            // numPointAX
            // 
            this.numPointAX.Location = new System.Drawing.Point(664, 6);
            this.numPointAX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointAX.Name = "numPointAX";
            this.numPointAX.Size = new System.Drawing.Size(42, 20);
            this.numPointAX.TabIndex = 72;
            this.numPointAX.Value = new decimal(new int[] {
            325,
            0,
            0,
            0});
            // 
            // numPointBX
            // 
            this.numPointBX.Location = new System.Drawing.Point(664, 30);
            this.numPointBX.Maximum = new decimal(new int[] {
            790,
            0,
            0,
            0});
            this.numPointBX.Name = "numPointBX";
            this.numPointBX.Size = new System.Drawing.Size(42, 20);
            this.numPointBX.TabIndex = 73;
            this.numPointBX.Value = new decimal(new int[] {
            425,
            0,
            0,
            0});
            // 
            // numPointAY
            // 
            this.numPointAY.Location = new System.Drawing.Point(593, 4);
            this.numPointAY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointAY.Name = "numPointAY";
            this.numPointAY.Size = new System.Drawing.Size(42, 20);
            this.numPointAY.TabIndex = 74;
            this.numPointAY.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // numPointBY
            // 
            this.numPointBY.Location = new System.Drawing.Point(593, 30);
            this.numPointBY.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.numPointBY.Name = "numPointBY";
            this.numPointBY.Size = new System.Drawing.Size(42, 20);
            this.numPointBY.TabIndex = 75;
            this.numPointBY.Value = new decimal(new int[] {
            450,
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
            this.Controls.Add(this.numPointBY);
            this.Controls.Add(this.numPointAY);
            this.Controls.Add(this.numPointBX);
            this.Controls.Add(this.numPointAX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخت فیثاغورث";
            ((System.ComponentModel.ISupportInitialize)(this.numPointAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointBY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPointAX;
        private System.Windows.Forms.NumericUpDown numPointBX;
        private System.Windows.Forms.NumericUpDown numPointAY;
        private System.Windows.Forms.NumericUpDown numPointBY;
    }
}

