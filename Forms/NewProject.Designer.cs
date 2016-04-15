namespace InvoiceTracker.Forms
{
    partial class NewProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbProjectId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSupDistrict = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbProjectId
            // 
            this.txbProjectId.Location = new System.Drawing.Point(100, 32);
            this.txbProjectId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbProjectId.Name = "txbProjectId";
            this.txbProjectId.Size = new System.Drawing.Size(132, 20);
            this.txbProjectId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbProjectName
            // 
            this.txbProjectName.Location = new System.Drawing.Point(100, 10);
            this.txbProjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbProjectName.Name = "txbProjectName";
            this.txbProjectName.Size = new System.Drawing.Size(213, 20);
            this.txbProjectName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Summary";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(100, 78);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(213, 134);
            this.txtSummary.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Supervisor District";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbSupDistrict
            // 
            this.txbSupDistrict.Location = new System.Drawing.Point(100, 55);
            this.txbSupDistrict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSupDistrict.Name = "txbSupDistrict";
            this.txbSupDistrict.Size = new System.Drawing.Size(132, 20);
            this.txbSupDistrict.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(256, 217);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(56, 19);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(195, 216);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(56, 19);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 243);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSupDistrict);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbProjectId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewProject";
            this.Text = "Create New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProjectId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSupDistrict;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}