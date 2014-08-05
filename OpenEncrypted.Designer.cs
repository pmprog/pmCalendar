namespace pmCalendar
{
	partial class OpenEncrypted
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.okayButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.usePassword = new System.Windows.Forms.RadioButton();
			this.useKey = new System.Windows.Forms.RadioButton();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.privateKeyFile = new System.Windows.Forms.TextBox();
			this.browseKey = new System.Windows.Forms.Button();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.okayButton, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 43);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// okayButton
			// 
			this.okayButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.okayButton.Location = new System.Drawing.Point(197, 5);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(74, 26);
			this.okayButton.TabIndex = 0;
			this.okayButton.Text = "Okay";
			this.okayButton.UseVisualStyleBackColor = true;
			this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cancelButton.Location = new System.Drawing.Point(277, 5);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(74, 26);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(374, 48);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// usePassword
			// 
			this.usePassword.AutoSize = true;
			this.usePassword.Location = new System.Drawing.Point(12, 56);
			this.usePassword.Name = "usePassword";
			this.usePassword.Size = new System.Drawing.Size(74, 17);
			this.usePassword.TabIndex = 3;
			this.usePassword.TabStop = true;
			this.usePassword.Text = "Password:";
			this.usePassword.UseVisualStyleBackColor = true;
			// 
			// useKey
			// 
			this.useKey.AutoSize = true;
			this.useKey.Location = new System.Drawing.Point(12, 80);
			this.useKey.Name = "useKey";
			this.useKey.Size = new System.Drawing.Size(82, 17);
			this.useKey.TabIndex = 4;
			this.useKey.TabStop = true;
			this.useKey.Text = "Private Key:";
			this.useKey.UseVisualStyleBackColor = true;
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(104, 56);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(256, 20);
			this.passwordText.TabIndex = 5;
			this.passwordText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// privateKeyFile
			// 
			this.privateKeyFile.Location = new System.Drawing.Point(104, 80);
			this.privateKeyFile.Name = "privateKeyFile";
			this.privateKeyFile.Size = new System.Drawing.Size(232, 20);
			this.privateKeyFile.TabIndex = 6;
			this.privateKeyFile.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// browseKey
			// 
			this.browseKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browseKey.Location = new System.Drawing.Point(340, 80);
			this.browseKey.Name = "browseKey";
			this.browseKey.Size = new System.Drawing.Size(20, 20);
			this.browseKey.TabIndex = 9;
			this.browseKey.UseVisualStyleBackColor = true;
			this.browseKey.Click += new System.EventHandler(this.browseKey_Click);
			// 
			// ofd
			// 
			this.ofd.Filter = "Key File (*.key)|*.key|All Files|*.*";
			// 
			// OpenEncrypted
			// 
			this.AcceptButton = this.okayButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(374, 147);
			this.Controls.Add(this.browseKey);
			this.Controls.Add(this.privateKeyFile);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.useKey);
			this.Controls.Add(this.usePassword);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OpenEncrypted";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Open Encrypted File";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button browseKey;
		private System.Windows.Forms.OpenFileDialog ofd;
		internal System.Windows.Forms.RadioButton usePassword;
		internal System.Windows.Forms.RadioButton useKey;
		internal System.Windows.Forms.TextBox passwordText;
		internal System.Windows.Forms.TextBox privateKeyFile;
	}
}