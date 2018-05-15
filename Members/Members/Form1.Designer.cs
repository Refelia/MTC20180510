namespace Members
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
            this.memSortDatagrid = new System.Windows.Forms.DataGridView();
            this.loadBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.reformatDateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memSortDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // memSortDatagrid
            // 
            this.memSortDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memSortDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memSortDatagrid.Location = new System.Drawing.Point(12, 21);
            this.memSortDatagrid.MultiSelect = false;
            this.memSortDatagrid.Name = "memSortDatagrid";
            this.memSortDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memSortDatagrid.Size = new System.Drawing.Size(715, 301);
            this.memSortDatagrid.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(64, 340);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(469, 340);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // reformatDateBtn
            // 
            this.reformatDateBtn.Location = new System.Drawing.Point(260, 340);
            this.reformatDateBtn.Name = "reformatDateBtn";
            this.reformatDateBtn.Size = new System.Drawing.Size(104, 23);
            this.reformatDateBtn.TabIndex = 3;
            this.reformatDateBtn.Text = "Reformat the Date";
            this.reformatDateBtn.UseVisualStyleBackColor = true;
            this.reformatDateBtn.Click += new System.EventHandler(this.reformatDateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 375);
            this.Controls.Add(this.reformatDateBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.memSortDatagrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.memSortDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView memSortDatagrid;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button reformatDateBtn;
    }
}

