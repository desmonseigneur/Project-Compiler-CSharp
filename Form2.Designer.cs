namespace ProjectCompiler
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.DBViewer = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLB = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.Transfer = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Revert = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // DBViewer
            // 
            this.DBViewer.AllowUserToAddRows = false;
            this.DBViewer.AllowUserToDeleteRows = false;
            this.DBViewer.AllowUserToResizeColumns = false;
            this.DBViewer.AllowUserToResizeRows = false;
            this.DBViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DBViewer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DBViewer.ColumnHeadersHeight = 29;
            this.DBViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DBViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DBViewer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DBViewer.Location = new System.Drawing.Point(7, 89);
            this.DBViewer.Name = "DBViewer";
            this.DBViewer.RowHeadersVisible = false;
            this.DBViewer.RowHeadersWidth = 51;
            this.DBViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DBViewer.RowTemplate.Height = 24;
            this.DBViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DBViewer.ShowEditingIcon = false;
            this.DBViewer.Size = new System.Drawing.Size(1268, 709);
            this.DBViewer.TabIndex = 1;
            this.DBViewer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBViewer_CellDoubleClick);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Arial", 10F);
            this.SearchBox.Location = new System.Drawing.Point(111, 44);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(204, 27);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchLB
            // 
            this.SearchLB.AutoSize = true;
            this.SearchLB.Font = new System.Drawing.Font("Arial", 10F);
            this.SearchLB.Location = new System.Drawing.Point(12, 16);
            this.SearchLB.Name = "SearchLB";
            this.SearchLB.Size = new System.Drawing.Size(90, 19);
            this.SearchLB.TabIndex = 4;
            this.SearchLB.Text = "Search by:";
            // 
            // SearchCB
            // 
            this.SearchCB.Font = new System.Drawing.Font("Arial", 10F);
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Items.AddRange(new object[] {
            "Project Year",
            "Project/Program/Activity",
            "Location",
            "Notice to Proceed",
            "Date Started",
            "Target Completion Date",
            "Project Status (%)",
            "Inspection Date",
            "Project Coordinator",
            "Source of Fund",
            "Contractor"});
            this.SearchCB.Location = new System.Drawing.Point(111, 14);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(204, 27);
            this.SearchCB.TabIndex = 6;
            this.SearchCB.Text = "Please select";
            this.SearchCB.SelectedIndexChanged += new System.EventHandler(this.SearchCB_SelectedIndexChanged);
            // 
            // Transfer
            // 
            this.Transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Transfer.Font = new System.Drawing.Font("Arial", 10F);
            this.Transfer.Location = new System.Drawing.Point(1113, 14);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(151, 55);
            this.Transfer.TabIndex = 7;
            this.Transfer.Text = "Transfer Data \r\nto Excel";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Show
            // 
            this.Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Show.Font = new System.Drawing.Font("Arial", 10F);
            this.Show.Location = new System.Drawing.Point(1114, 13);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(151, 55);
            this.Show.TabIndex = 8;
            this.Show.Text = "Show Full Table";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Revert
            // 
            this.Revert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Revert.Font = new System.Drawing.Font("Arial", 10F);
            this.Revert.Location = new System.Drawing.Point(957, 14);
            this.Revert.Name = "Revert";
            this.Revert.Size = new System.Drawing.Size(151, 55);
            this.Revert.TabIndex = 9;
            this.Revert.Text = "Revert";
            this.Revert.UseVisualStyleBackColor = true;
            this.Revert.Visible = false;
            this.Revert.Click += new System.EventHandler(this.Revert_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1111, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Created by: J. Masunsong";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.Revert);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.SearchCB);
            this.Controls.Add(this.SearchLB);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DBViewer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects List";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DBViewer;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLB;
        private System.Windows.Forms.ComboBox SearchCB;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Revert;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
    }
}