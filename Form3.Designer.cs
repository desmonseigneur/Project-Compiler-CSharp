namespace ProjectCompiler
{
    partial class Form3
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
            this.UNLB = new System.Windows.Forms.Label();
            this.PWLB = new System.Windows.Forms.Label();
            this.UNBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UNLB
            // 
            this.UNLB.AutoSize = true;
            this.UNLB.Location = new System.Drawing.Point(66, 43);
            this.UNLB.Name = "UNLB";
            this.UNLB.Size = new System.Drawing.Size(73, 16);
            this.UNLB.TabIndex = 1;
            this.UNLB.Text = "Username:";
            // 
            // PWLB
            // 
            this.PWLB.AutoSize = true;
            this.PWLB.Location = new System.Drawing.Point(69, 81);
            this.PWLB.Name = "PWLB";
            this.PWLB.Size = new System.Drawing.Size(70, 16);
            this.PWLB.TabIndex = 2;
            this.PWLB.Text = "Password:";
            // 
            // UNBox
            // 
            this.UNBox.Font = new System.Drawing.Font("Arial", 12F);
            this.UNBox.Location = new System.Drawing.Point(164, 34);
            this.UNBox.Name = "UNBox";
            this.UNBox.Size = new System.Drawing.Size(176, 30);
            this.UNBox.TabIndex = 4;
            // 
            // PWBox
            // 
            this.PWBox.Font = new System.Drawing.Font("Arial", 12F);
            this.PWBox.Location = new System.Drawing.Point(164, 81);
            this.PWBox.Name = "PWBox";
            this.PWBox.PasswordChar = '*';
            this.PWBox.Size = new System.Drawing.Size(176, 30);
            this.PWBox.TabIndex = 5;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(146, 130);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 174);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.UNBox);
            this.Controls.Add(this.PWLB);
            this.Controls.Add(this.UNLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UNLB;
        private System.Windows.Forms.Label PWLB;
        private System.Windows.Forms.TextBox UNBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Button OK;
    }
}