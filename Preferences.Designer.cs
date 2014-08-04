namespace pmCalendar
{
	partial class Preferences
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
			this.button1 = new System.Windows.Forms.Button();
			this.specificDB = new System.Windows.Forms.TextBox();
			this.startNew = new System.Windows.Forms.RadioButton();
			this.startSpecific = new System.Windows.Forms.RadioButton();
			this.startLastDB = new System.Windows.Forms.RadioButton();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.okayButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.saveNever = new System.Windows.Forms.RadioButton();
			this.saveAlways = new System.Windows.Forms.RadioButton();
			this.saveAsk = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.toolsList = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolsList)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(380, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 20);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// specificDB
			// 
			this.specificDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.specificDB.Location = new System.Drawing.Point(24, 56);
			this.specificDB.Name = "specificDB";
			this.specificDB.Size = new System.Drawing.Size(352, 20);
			this.specificDB.TabIndex = 3;
			// 
			// startNew
			// 
			this.startNew.AutoSize = true;
			this.startNew.Location = new System.Drawing.Point(8, 84);
			this.startNew.Name = "startNew";
			this.startNew.Size = new System.Drawing.Size(96, 17);
			this.startNew.TabIndex = 2;
			this.startNew.Text = "New Database";
			this.startNew.UseVisualStyleBackColor = true;
			// 
			// startSpecific
			// 
			this.startSpecific.AutoSize = true;
			this.startSpecific.Location = new System.Drawing.Point(8, 36);
			this.startSpecific.Name = "startSpecific";
			this.startSpecific.Size = new System.Drawing.Size(141, 17);
			this.startSpecific.TabIndex = 1;
			this.startSpecific.Text = "Open Specific Database";
			this.startSpecific.UseVisualStyleBackColor = true;
			// 
			// startLastDB
			// 
			this.startLastDB.AutoSize = true;
			this.startLastDB.Checked = true;
			this.startLastDB.Location = new System.Drawing.Point(8, 12);
			this.startLastDB.Name = "startLastDB";
			this.startLastDB.Size = new System.Drawing.Size(123, 17);
			this.startLastDB.TabIndex = 0;
			this.startLastDB.TabStop = true;
			this.startLastDB.Text = "Open Last Database";
			this.startLastDB.UseVisualStyleBackColor = true;
			// 
			// ofd
			// 
			this.ofd.Filter = "pmContact Database|*.cdb";
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 231);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 51);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// okayButton
			// 
			this.okayButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.okayButton.Location = new System.Drawing.Point(239, 6);
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
			this.cancelButton.Location = new System.Drawing.Point(319, 6);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(74, 26);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(416, 227);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.startLastDB);
			this.tabPage1.Controls.Add(this.specificDB);
			this.tabPage1.Controls.Add(this.startSpecific);
			this.tabPage1.Controls.Add(this.startNew);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(408, 201);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Startup";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.saveNever);
			this.tabPage2.Controls.Add(this.saveAlways);
			this.tabPage2.Controls.Add(this.saveAsk);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(408, 201);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Saving";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// saveNever
			// 
			this.saveNever.AutoSize = true;
			this.saveNever.Location = new System.Drawing.Point(20, 76);
			this.saveNever.Name = "saveNever";
			this.saveNever.Size = new System.Drawing.Size(82, 17);
			this.saveNever.TabIndex = 3;
			this.saveNever.Text = "Never Save";
			this.saveNever.UseVisualStyleBackColor = true;
			// 
			// saveAlways
			// 
			this.saveAlways.AutoSize = true;
			this.saveAlways.Location = new System.Drawing.Point(20, 52);
			this.saveAlways.Name = "saveAlways";
			this.saveAlways.Size = new System.Drawing.Size(86, 17);
			this.saveAlways.TabIndex = 2;
			this.saveAlways.Text = "Always Save";
			this.saveAlways.UseVisualStyleBackColor = true;
			// 
			// saveAsk
			// 
			this.saveAsk.AutoSize = true;
			this.saveAsk.Checked = true;
			this.saveAsk.Location = new System.Drawing.Point(20, 28);
			this.saveAsk.Name = "saveAsk";
			this.saveAsk.Size = new System.Drawing.Size(79, 17);
			this.saveAsk.TabIndex = 1;
			this.saveAsk.TabStop = true;
			this.saveAsk.Text = "Always Ask";
			this.saveAsk.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "When opening a new DB or quitting, how do you want save?";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.toolsList);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(408, 201);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Tools";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "External Tools";
			// 
			// toolsList
			// 
			this.toolsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.toolsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.toolsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.toolsList.Location = new System.Drawing.Point(12, 24);
			this.toolsList.Name = "toolsList";
			this.toolsList.Size = new System.Drawing.Size(388, 168);
			this.toolsList.TabIndex = 1;
			// 
			// Preferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 286);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Preferences";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.Preferences_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolsList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox specificDB;
		private System.Windows.Forms.RadioButton startNew;
		private System.Windows.Forms.RadioButton startSpecific;
		private System.Windows.Forms.RadioButton startLastDB;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.RadioButton saveNever;
		private System.Windows.Forms.RadioButton saveAlways;
		private System.Windows.Forms.RadioButton saveAsk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView toolsList;
		private System.Windows.Forms.Label label2;
	}
}