namespace Chess
{
    partial class FrmChess
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
            this.PnlSqrt = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlSqrt
            // 
            this.PnlSqrt.Location = new System.Drawing.Point(13, 13);
            this.PnlSqrt.Name = "PnlSqrt";
            this.PnlSqrt.Size = new System.Drawing.Size(400, 400);
            this.PnlSqrt.TabIndex = 0;
            // 
            // FrmChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 436);
            this.Controls.Add(this.PnlSqrt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmChess";
            this.Text = "Mini Portable Chess Board";
            this.Load += new System.EventHandler(this.FrmChess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSqrt;
    }
}