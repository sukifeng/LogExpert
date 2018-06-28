namespace LogExpert.Dialogs
{
	partial class MultiFileMaskDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiFileMaskDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxDaysUpDown = new System.Windows.Forms.NumericUpDown();
            this.fileNamePatternTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.syntaxHelpLabel = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxDaysUpDown)).BeginInit();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MultiFile settings for:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(111, 12);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(71, 12);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "<file name>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "File name pattern:";
            // 
            // maxDaysUpDown
            // 
            this.maxDaysUpDown.Location = new System.Drawing.Point(123, 47);
            this.maxDaysUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.maxDaysUpDown.Name = "maxDaysUpDown";
            this.maxDaysUpDown.Size = new System.Drawing.Size(49, 21);
            this.maxDaysUpDown.TabIndex = 3;
            this.maxDaysUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fileNamePatternTextBox
            // 
            this.fileNamePatternTextBox.Location = new System.Drawing.Point(123, 23);
            this.fileNamePatternTextBox.Name = "fileNamePatternTextBox";
            this.fileNamePatternTextBox.Size = new System.Drawing.Size(157, 21);
            this.fileNamePatternTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max days:";
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.maxDaysUpDown);
            this.Settings.Controls.Add(this.fileNamePatternTextBox);
            this.Settings.Location = new System.Drawing.Point(15, 36);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(402, 81);
            this.Settings.TabIndex = 6;
            this.Settings.TabStop = false;
            // 
            // syntaxHelpLabel
            // 
            this.syntaxHelpLabel.Location = new System.Drawing.Point(15, 129);
            this.syntaxHelpLabel.Name = "syntaxHelpLabel";
            this.syntaxHelpLabel.Size = new System.Drawing.Size(402, 179);
            this.syntaxHelpLabel.TabIndex = 7;
            this.syntaxHelpLabel.Text = "label4";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(261, 320);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(342, 320);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // MultiFileMaskDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(434, 356);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.syntaxHelpLabel);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 391);
            this.Name = "MultiFileMaskDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MultiFile settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MultiFileMaskDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxDaysUpDown)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown maxDaysUpDown;
		private System.Windows.Forms.TextBox fileNamePatternTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox Settings;
		private System.Windows.Forms.Label syntaxHelpLabel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}