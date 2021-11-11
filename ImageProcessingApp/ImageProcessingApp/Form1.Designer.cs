namespace ImageProcessingApp
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picModified = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModified)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(52, 50);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(256, 256);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picModified
            // 
            this.picModified.Location = new System.Drawing.Point(399, 50);
            this.picModified.Name = "picModified";
            this.picModified.Size = new System.Drawing.Size(256, 256);
            this.picModified.TabIndex = 1;
            this.picModified.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Salmon;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpen.Location = new System.Drawing.Point(52, 312);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(256, 50);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Image Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Gray;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(399, 312);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(256, 50);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change to Grey";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.BackColor = System.Drawing.Color.Gray;
            this.btnMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedian.Location = new System.Drawing.Point(399, 368);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(256, 47);
            this.btnMedian.TabIndex = 4;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = false;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 562);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picModified);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Image Processing App";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModified)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picModified;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMedian;
    }
}

