namespace proiectPaw
{
	partial class AdaugaDisciplina
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
			this.Denumirelabel = new System.Windows.Forms.Label();
			this.Creditelabel = new System.Windows.Forms.Label();
			this.DenumireTextBox = new System.Windows.Forms.TextBox();
			this.CrediteTextBox = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Denumirelabel
			// 
			this.Denumirelabel.AutoSize = true;
			this.Denumirelabel.Location = new System.Drawing.Point(23, 20);
			this.Denumirelabel.Name = "Denumirelabel";
			this.Denumirelabel.Size = new System.Drawing.Size(78, 20);
			this.Denumirelabel.TabIndex = 0;
			this.Denumirelabel.Text = "Denumire";
			// 
			// Creditelabel
			// 
			this.Creditelabel.AutoSize = true;
			this.Creditelabel.Location = new System.Drawing.Point(23, 78);
			this.Creditelabel.Name = "Creditelabel";
			this.Creditelabel.Size = new System.Drawing.Size(60, 20);
			this.Creditelabel.TabIndex = 1;
			this.Creditelabel.Text = "Credite";
			// 
			// DenumireTextBox
			// 
			this.DenumireTextBox.Location = new System.Drawing.Point(138, 20);
			this.DenumireTextBox.Name = "DenumireTextBox";
			this.DenumireTextBox.Size = new System.Drawing.Size(543, 26);
			this.DenumireTextBox.TabIndex = 2;
			// 
			// CrediteTextBox
			// 
			this.CrediteTextBox.Location = new System.Drawing.Point(138, 78);
			this.CrediteTextBox.Name = "CrediteTextBox";
			this.CrediteTextBox.Size = new System.Drawing.Size(543, 26);
			this.CrediteTextBox.TabIndex = 3;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(236, 158);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(86, 71);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(347, 158);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(86, 71);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// AdaugaDisciplina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 256);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CrediteTextBox);
			this.Controls.Add(this.DenumireTextBox);
			this.Controls.Add(this.Creditelabel);
			this.Controls.Add(this.Denumirelabel);
			this.Name = "AdaugaDisciplina";
			this.Text = "AdaugaDisciplina";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Denumirelabel;
		private System.Windows.Forms.Label Creditelabel;
		private System.Windows.Forms.TextBox DenumireTextBox;
		private System.Windows.Forms.TextBox CrediteTextBox;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CancelButton;
	}
}