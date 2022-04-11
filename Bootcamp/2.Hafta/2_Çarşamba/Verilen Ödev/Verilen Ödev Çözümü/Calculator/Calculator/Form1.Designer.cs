namespace Calculator
{
    partial class Form1
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
            this.TxtNumbers = new System.Windows.Forms.TextBox();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnMines = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumbers
            // 
            this.TxtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtNumbers.Location = new System.Drawing.Point(14, 49);
            this.TxtNumbers.Name = "TxtNumbers";
            this.TxtNumbers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNumbers.Size = new System.Drawing.Size(235, 30);
            this.TxtNumbers.TabIndex = 0;
            this.TxtNumbers.Text = "0";
            this.TxtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnEqual.Location = new System.Drawing.Point(264, 262);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(48, 35);
            this.BtnEqual.TabIndex = 1;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnSum.Location = new System.Drawing.Point(264, 216);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(48, 35);
            this.BtnSum.TabIndex = 2;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnMines
            // 
            this.BtnMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnMines.Location = new System.Drawing.Point(264, 169);
            this.BtnMines.Name = "BtnMines";
            this.BtnMines.Size = new System.Drawing.Size(48, 41);
            this.BtnMines.TabIndex = 3;
            this.BtnMines.Text = "-";
            this.BtnMines.UseVisualStyleBackColor = true;
            this.BtnMines.Click += new System.EventHandler(this.BtnMines_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnMul.Location = new System.Drawing.Point(264, 126);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(47, 37);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "x";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnDiv.Location = new System.Drawing.Point(264, 81);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(48, 39);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnClear.Location = new System.Drawing.Point(12, 249);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 48);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnNine.Location = new System.Drawing.Point(174, 93);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(75, 46);
            this.BtnNine.TabIndex = 10;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnSix
            // 
            this.BtnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnSix.Location = new System.Drawing.Point(174, 145);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(75, 46);
            this.BtnSix.TabIndex = 9;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnThree
            // 
            this.BtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnThree.Location = new System.Drawing.Point(174, 197);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(1);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(75, 46);
            this.BtnThree.TabIndex = 8;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnEight
            // 
            this.BtnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnEight.Location = new System.Drawing.Point(93, 93);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(75, 46);
            this.BtnEight.TabIndex = 16;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnFive
            // 
            this.BtnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnFive.Location = new System.Drawing.Point(93, 145);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(1);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(75, 46);
            this.BtnFive.TabIndex = 15;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnTwo.Location = new System.Drawing.Point(93, 197);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(1);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(75, 46);
            this.BtnTwo.TabIndex = 14;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnZero
            // 
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnZero.Location = new System.Drawing.Point(93, 249);
            this.BtnZero.Margin = new System.Windows.Forms.Padding(1);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(75, 46);
            this.BtnZero.TabIndex = 13;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnSeven.Location = new System.Drawing.Point(12, 93);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(75, 46);
            this.BtnSeven.TabIndex = 22;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnFour
            // 
            this.BtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnFour.Location = new System.Drawing.Point(12, 145);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(1);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(75, 46);
            this.BtnFour.TabIndex = 21;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnOne
            // 
            this.BtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnOne.Location = new System.Drawing.Point(12, 197);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(1);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(75, 46);
            this.BtnOne.TabIndex = 20;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.SelectedButtons);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnDot.Location = new System.Drawing.Point(174, 249);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDot.Size = new System.Drawing.Size(75, 46);
            this.BtnDot.TabIndex = 7;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Storm Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(323, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnMines);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.TxtNumbers);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumbers;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnMines;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Label label1;
    }
}

