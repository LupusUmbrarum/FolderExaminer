namespace FolderExaminer
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
			this.components = new System.ComponentModel.Container();
			this.findFolderButton = new System.Windows.Forms.Button();
			this.folderPathTextBox = new System.Windows.Forms.TextBox();
			this.examineFolderButton = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// findFolderButton
			// 
			this.findFolderButton.Location = new System.Drawing.Point(112, 13);
			this.findFolderButton.Name = "findFolderButton";
			this.findFolderButton.Size = new System.Drawing.Size(75, 23);
			this.findFolderButton.TabIndex = 0;
			this.findFolderButton.Text = "Find Folder";
			this.findFolderButton.UseVisualStyleBackColor = true;
			this.findFolderButton.Click += new System.EventHandler(this.findFolderButton_Click);
			// 
			// folderPathTextBox
			// 
			this.folderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.folderPathTextBox.Location = new System.Drawing.Point(193, 15);
			this.folderPathTextBox.Name = "folderPathTextBox";
			this.folderPathTextBox.Size = new System.Drawing.Size(595, 20);
			this.folderPathTextBox.TabIndex = 1;
			this.folderPathTextBox.DoubleClick += new System.EventHandler(this.folderPathTextBox_DoubleClick);
			// 
			// examineFolderButton
			// 
			this.examineFolderButton.Location = new System.Drawing.Point(12, 13);
			this.examineFolderButton.Name = "examineFolderButton";
			this.examineFolderButton.Size = new System.Drawing.Size(94, 23);
			this.examineFolderButton.TabIndex = 0;
			this.examineFolderButton.Text = "Examine Folder";
			this.examineFolderButton.UseVisualStyleBackColor = true;
			this.examineFolderButton.Click += new System.EventHandler(this.examineFolderButton_Click);
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(12, 42);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(776, 396);
			this.treeView1.TabIndex = 2;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.folderPathTextBox);
			this.Controls.Add(this.examineFolderButton);
			this.Controls.Add(this.findFolderButton);
			this.Name = "Form1";
			this.Text = "FolderExaminer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button findFolderButton;
		private System.Windows.Forms.TextBox folderPathTextBox;
		private System.Windows.Forms.Button examineFolderButton;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.ImageList imageList1;
	}
}

