namespace CloneHub
{
	partial class HomePage
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
			this.label2 = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pathTextBox = new System.Windows.Forms.TextBox();
			this.repoUrlTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cloneButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(218, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "CloneHub";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Directory";
			// 
			// browseButton
			// 
			this.browseButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseButton.Location = new System.Drawing.Point(548, 96);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(82, 32);
			this.browseButton.TabIndex = 2;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "RepoUrls:";
			// 
			// pathTextBox
			// 
			this.pathTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pathTextBox.Location = new System.Drawing.Point(133, 96);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.Size = new System.Drawing.Size(392, 26);
			this.pathTextBox.TabIndex = 1;
			// 
			// repoUrlTextBox
			// 
			this.repoUrlTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.repoUrlTextBox.Location = new System.Drawing.Point(133, 157);
			this.repoUrlTextBox.Multiline = true;
			this.repoUrlTextBox.Name = "repoUrlTextBox";
			this.repoUrlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.repoUrlTextBox.Size = new System.Drawing.Size(497, 196);
			this.repoUrlTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(156, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(295, 36);
			this.label4.TabIndex = 4;
			this.label4.Text = " An application designed to simplify the process of \r\ncloning Git repositories.";
			// 
			// cloneButton
			// 
			this.cloneButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cloneButton.Location = new System.Drawing.Point(192, 389);
			this.cloneButton.Name = "cloneButton";
			this.cloneButton.Size = new System.Drawing.Size(302, 43);
			this.cloneButton.TabIndex = 5;
			this.cloneButton.Text = "Clone";
			this.cloneButton.UseVisualStyleBackColor = true;
			this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(642, 444);
			this.Controls.Add(this.cloneButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.repoUrlTextBox);
			this.Controls.Add(this.pathTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.Name = "HomePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CloneHub";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.HomePage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox pathTextBox;
		private System.Windows.Forms.TextBox repoUrlTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cloneButton;
	}
}

