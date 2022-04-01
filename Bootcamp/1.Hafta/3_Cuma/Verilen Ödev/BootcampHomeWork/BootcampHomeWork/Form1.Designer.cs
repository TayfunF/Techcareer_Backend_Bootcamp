namespace BootcampHomeWork
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
            this.Add = new System.Windows.Forms.Button();
            this.RemoveAt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtNumbers
            // 
            this.TxtNumbers.Location = new System.Drawing.Point(21, 175);
            this.TxtNumbers.Name = "TxtNumbers";
            this.TxtNumbers.Size = new System.Drawing.Size(288, 20);
            this.TxtNumbers.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add.Location = new System.Drawing.Point(21, 217);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 31);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // RemoveAt
            // 
            this.RemoveAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveAt.Location = new System.Drawing.Point(189, 217);
            this.RemoveAt.Name = "RemoveAt";
            this.RemoveAt.Size = new System.Drawing.Size(120, 31);
            this.RemoveAt.TabIndex = 2;
            this.RemoveAt.Text = "Remove At";
            this.RemoveAt.UseVisualStyleBackColor = true;
            this.RemoveAt.Click += new System.EventHandler(this.RemoveAt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(374, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elements Of List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(379, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 199);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 668);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveAt);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TxtNumbers);
            this.Name = "Form1";
            this.Text = "HomeWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumbers;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button RemoveAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

