﻿namespace proiectPaw
{
	partial class StergeDisciplina
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
			this.StergeDisciplinaTextBox = new System.Windows.Forms.TextBox();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Introduce Id-ul";
			// 
			// StergeDisciplinaTextBox
			// 
			this.StergeDisciplinaTextBox.Location = new System.Drawing.Point(130, 28);
			this.StergeDisciplinaTextBox.Name = "StergeDisciplinaTextBox";
			this.StergeDisciplinaTextBox.Size = new System.Drawing.Size(354, 26);
			this.StergeDisciplinaTextBox.TabIndex = 1;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(210, 100);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(85, 62);
			this.DeleteButton.TabIndex = 2;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(335, 100);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(85, 62);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// StergeDisciplina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(512, 195);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.StergeDisciplinaTextBox);
			this.Controls.Add(this.label1);
			this.Name = "StergeDisciplina";
			this.Text = "StergeDisciplina";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox StergeDisciplinaTextBox;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button CancelButton;
	}
}