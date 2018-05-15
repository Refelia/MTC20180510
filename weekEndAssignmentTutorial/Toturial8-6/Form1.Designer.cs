namespace Toturial8_6
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
            this.redLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.indigoLabel = new System.Windows.Forms.Label();
            this.violetLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLabel.Location = new System.Drawing.Point(49, 54);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(35, 13);
            this.redLabel.TabIndex = 0;
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // orangeLabel
            // 
            this.orangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeLabel.Location = new System.Drawing.Point(118, 54);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(35, 13);
            this.orangeLabel.TabIndex = 1;
            this.orangeLabel.Click += new System.EventHandler(this.orangeLabel_Click);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowLabel.Location = new System.Drawing.Point(182, 54);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(35, 13);
            this.yellowLabel.TabIndex = 2;
            this.yellowLabel.Click += new System.EventHandler(this.yellowLabel_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenLabel.Location = new System.Drawing.Point(241, 54);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(35, 13);
            this.greenLabel.TabIndex = 3;
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // blueLabel
            // 
            this.blueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueLabel.Location = new System.Drawing.Point(307, 54);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(35, 13);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // indigoLabel
            // 
            this.indigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indigoLabel.Location = new System.Drawing.Point(365, 54);
            this.indigoLabel.Name = "indigoLabel";
            this.indigoLabel.Size = new System.Drawing.Size(35, 13);
            this.indigoLabel.TabIndex = 5;
            this.indigoLabel.Click += new System.EventHandler(this.indigoLabel_Click);
            // 
            // violetLabel
            // 
            this.violetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.violetLabel.Location = new System.Drawing.Point(424, 54);
            this.violetLabel.Name = "violetLabel";
            this.violetLabel.Size = new System.Drawing.Size(35, 13);
            this.violetLabel.TabIndex = 6;
            this.violetLabel.Click += new System.EventHandler(this.violetLabel_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Location = new System.Drawing.Point(182, 106);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(100, 23);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 158);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.violetLabel);
            this.Controls.Add(this.indigoLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "Form1";
            this.Text = "Color Spectrum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label orangeLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label indigoLabel;
        private System.Windows.Forms.Label violetLabel;
        private System.Windows.Forms.Label colorLabel;
    }
}

