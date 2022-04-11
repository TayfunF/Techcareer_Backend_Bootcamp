namespace CopyTheCalculator
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
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PnlNumbers = new System.Windows.Forms.Panel();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn00 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.ResultPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PnlNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultPanel
            // 
            this.ResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultPanel.Controls.Add(this.TxtResult);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(306, 44);
            this.ResultPanel.TabIndex = 0;
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtResult.Location = new System.Drawing.Point(0, 0);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(302, 38);
            this.TxtResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEqual);
            this.groupBox1.Controls.Add(this.BtnDiv);
            this.groupBox1.Controls.Add(this.BtnMul);
            this.groupBox1.Controls.Add(this.BtnSub);
            this.groupBox1.Controls.Add(this.BtnSum);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.PnlNumbers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEqual.Location = new System.Drawing.Point(227, 10);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(69, 199);
            this.BtnEqual.TabIndex = 6;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDiv.Location = new System.Drawing.Point(176, 174);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(45, 35);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMul.Location = new System.Drawing.Point(176, 133);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(45, 35);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSub.Location = new System.Drawing.Point(176, 93);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(45, 35);
            this.BtnSub.TabIndex = 3;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSum.Location = new System.Drawing.Point(176, 52);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(45, 35);
            this.BtnSum.TabIndex = 2;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Location = new System.Drawing.Point(176, 10);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(45, 35);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // PnlNumbers
            // 
            this.PnlNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNumbers.Controls.Add(this.BtnDot);
            this.PnlNumbers.Controls.Add(this.Btn0);
            this.PnlNumbers.Controls.Add(this.Btn00);
            this.PnlNumbers.Controls.Add(this.Btn3);
            this.PnlNumbers.Controls.Add(this.Btn2);
            this.PnlNumbers.Controls.Add(this.Btn1);
            this.PnlNumbers.Controls.Add(this.Btn6);
            this.PnlNumbers.Controls.Add(this.Btn5);
            this.PnlNumbers.Controls.Add(this.Btn4);
            this.PnlNumbers.Controls.Add(this.Btn9);
            this.PnlNumbers.Controls.Add(this.Btn8);
            this.PnlNumbers.Controls.Add(this.Btn7);
            this.PnlNumbers.Location = new System.Drawing.Point(2, 10);
            this.PnlNumbers.Name = "PnlNumbers";
            this.PnlNumbers.Size = new System.Drawing.Size(168, 188);
            this.PnlNumbers.TabIndex = 0;
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDot.Location = new System.Drawing.Point(111, 141);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(45, 35);
            this.BtnDot.TabIndex = 11;
            this.BtnDot.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn0.Location = new System.Drawing.Point(60, 141);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(45, 35);
            this.Btn0.TabIndex = 10;
            this.Btn0.UseVisualStyleBackColor = true;
            // 
            // Btn00
            // 
            this.Btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn00.Location = new System.Drawing.Point(9, 141);
            this.Btn00.Name = "Btn00";
            this.Btn00.Size = new System.Drawing.Size(45, 35);
            this.Btn00.TabIndex = 9;
            this.Btn00.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn3.Location = new System.Drawing.Point(111, 100);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 35);
            this.Btn3.TabIndex = 8;
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn2.Location = new System.Drawing.Point(60, 100);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 35);
            this.Btn2.TabIndex = 7;
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn1.Location = new System.Drawing.Point(9, 100);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 35);
            this.Btn1.TabIndex = 6;
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn6.Location = new System.Drawing.Point(111, 59);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(45, 35);
            this.Btn6.TabIndex = 5;
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn5.Location = new System.Drawing.Point(60, 59);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(45, 35);
            this.Btn5.TabIndex = 4;
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn4.Location = new System.Drawing.Point(9, 59);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 35);
            this.Btn4.TabIndex = 3;
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn9.Location = new System.Drawing.Point(111, 18);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(45, 35);
            this.Btn9.TabIndex = 2;
            this.Btn9.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn8.Location = new System.Drawing.Point(60, 18);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(45, 35);
            this.Btn8.TabIndex = 1;
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn7.Location = new System.Drawing.Point(9, 18);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(45, 35);
            this.Btn7.TabIndex = 0;
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultPanel);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.PnlNumbers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PnlNumbers;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn00;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnEqual;
    }
}