namespace windowsFormApplication
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
            this.BtnClick = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.ShowText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClick
            // 
            this.BtnClick.Location = new System.Drawing.Point(101, 139);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(75, 23);
            this.BtnClick.TabIndex = 0;
            this.BtnClick.Text = "Click me";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(80, 96);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(138, 20);
            this.textName.TabIndex = 0;
            // 
            // ShowText
            // 
            this.ShowText.AutoSize = true;
            this.ShowText.Location = new System.Drawing.Point(77, 69);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(132, 13);
            this.ShowText.TabIndex = 1;
            this.ShowText.Text = "Enter Your Name Please !!";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.BtnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label ShowText;
    }
}

