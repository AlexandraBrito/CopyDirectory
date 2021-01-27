namespace CopyDirectory
{
    partial class CopyDirectoryForm
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
            this.fromPath = new System.Windows.Forms.TextBox();
            this.CopyFromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.toPath = new System.Windows.Forms.TextBox();
            this.fromBrowse = new System.Windows.Forms.Button();
            this.toBrowse = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.copingInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fromPath
            // 
            this.fromPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromPath.Location = new System.Drawing.Point(28, 32);
            this.fromPath.Name = "fromPath";
            this.fromPath.Size = new System.Drawing.Size(456, 20);
            this.fromPath.TabIndex = 0;
            // 
            // CopyFromLabel
            // 
            this.CopyFromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyFromLabel.AutoSize = true;
            this.CopyFromLabel.Location = new System.Drawing.Point(25, 16);
            this.CopyFromLabel.Name = "CopyFromLabel";
            this.CopyFromLabel.Size = new System.Drawing.Size(57, 13);
            this.CopyFromLabel.TabIndex = 1;
            this.CopyFromLabel.Text = "Copy from:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(25, 72);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To:";
            // 
            // toPath
            // 
            this.toPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toPath.Location = new System.Drawing.Point(28, 88);
            this.toPath.Name = "toPath";
            this.toPath.Size = new System.Drawing.Size(456, 20);
            this.toPath.TabIndex = 2;
            // 
            // fromBrowse
            // 
            this.fromBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromBrowse.Location = new System.Drawing.Point(490, 28);
            this.fromBrowse.Name = "fromBrowse";
            this.fromBrowse.Size = new System.Drawing.Size(79, 26);
            this.fromBrowse.TabIndex = 4;
            this.fromBrowse.Text = "Browse";
            this.fromBrowse.UseVisualStyleBackColor = true;
            this.fromBrowse.Click += new System.EventHandler(this.fromBrowse_Click);
            // 
            // toBrowse
            // 
            this.toBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toBrowse.Location = new System.Drawing.Point(490, 84);
            this.toBrowse.Name = "toBrowse";
            this.toBrowse.Size = new System.Drawing.Size(79, 26);
            this.toBrowse.TabIndex = 5;
            this.toBrowse.Text = "Browse";
            this.toBrowse.UseVisualStyleBackColor = true;
            this.toBrowse.Click += new System.EventHandler(this.toBrowse_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(28, 125);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(97, 26);
            this.CopyBtn.TabIndex = 6;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // copingInfoTextBox
            // 
            this.copingInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copingInfoTextBox.Location = new System.Drawing.Point(42, 166);
            this.copingInfoTextBox.Name = "copingInfoTextBox";
            this.copingInfoTextBox.Size = new System.Drawing.Size(516, 155);
            this.copingInfoTextBox.TabIndex = 7;
            this.copingInfoTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 363);
            this.Controls.Add(this.copingInfoTextBox);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.toBrowse);
            this.Controls.Add(this.fromBrowse);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.toPath);
            this.Controls.Add(this.CopyFromLabel);
            this.Controls.Add(this.fromPath);
            this.Name = "Form1";
            this.Text = "CopyDirectory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromPath;
        private System.Windows.Forms.Label CopyFromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox toPath;
        private System.Windows.Forms.Button fromBrowse;
        private System.Windows.Forms.Button toBrowse;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.RichTextBox copingInfoTextBox;
    }
}

